using System.Net.WebSockets;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseWebSockets();

app.Map("/ws", async context =>
{
    if (context.WebSockets.IsWebSocketRequest)
    {
        using var webSocket = await context.WebSockets.AcceptWebSocketAsync();
        Console.WriteLine("Cliente conectado via WebSocket.");

        var buffer = new byte[1024 * 4];
        WebSocketReceiveResult result;
        
        while (true)
        {
            result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                Console.WriteLine("Cliente pediu para fechar a conexão.");
                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                break;
            }
            else if (result.MessageType == WebSocketMessageType.Text)
            {
                var mensagemRecebida = Encoding.UTF8.GetString(buffer, 0, result.Count);

                Console.WriteLine($"Dado Recebido, Direção : {mensagemRecebida}");

                var resposta = $"Servidor recebeu: {mensagemRecebida}";
                var respostaBytes = Encoding.UTF8.GetBytes(resposta);
                await webSocket.SendAsync(
                    new ArraySegment<byte>(respostaBytes, 0, respostaBytes.Length),
                    WebSocketMessageType.Text,
                    true,
                    CancellationToken.None
                );
            }
        }
    }
    else
    {
        context.Response.StatusCode = 400;
    }
});

app.Run();
