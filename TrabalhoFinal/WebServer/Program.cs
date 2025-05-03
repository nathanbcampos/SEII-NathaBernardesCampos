using System.Net.WebSockets;
using System.Text;
using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:5000");
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseWebSockets();

// Lista de clientes WebSocket conectados
var webSockets = new ConcurrentBag<WebSocket>();

app.Map("/ws", async context =>
{
    if (!context.WebSockets.IsWebSocketRequest)
    {
        context.Response.StatusCode = 400;
        return;
    }

    using var webSocket = await context.WebSockets.AcceptWebSocketAsync();
    Console.WriteLine("Cliente conectado via WebSocket.");
    webSockets.Add(webSocket);

    var buffer = new byte[1024 * 1024 * 5]; // até 5 MB
    WebSocketReceiveResult result;

    try
    {
        while (true)
        {
            result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                Console.WriteLine("Cliente pediu para fechar a conexão.");
                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                break;
            }

            if (result.MessageType == WebSocketMessageType.Text)
            {
                var texto = Encoding.UTF8.GetString(buffer, 0, result.Count);
                Console.WriteLine($"Dado Texto Recebido: {texto}");

                // reenvia como mensagem de texto a todos
                foreach (var sock in webSockets)
                {
                    if (sock.State == WebSocketState.Open)
                    {
                        var bytes = Encoding.UTF8.GetBytes($"Mensagem recebida: {texto}");
                        await sock.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None);
                    }
                }
            }
            else if (result.MessageType == WebSocketMessageType.Binary)
            {
                // Recebe um blob de bytes da imagem
                var imagemBytes = new byte[result.Count];
                Array.Copy(buffer, imagemBytes, result.Count);
                Console.WriteLine($"Imagem Recebida, {imagemBytes.Length} bytes");

                // Converte para Base64 e empacota como data URI
                var b64 = Convert.ToBase64String(imagemBytes);
                var dataUri = "data:image/png;base64," + b64;

                // Envia de volta como texto contendo o data URI
                var uriBytes = Encoding.UTF8.GetBytes(dataUri);
                foreach (var sock in webSockets)
                {
                    if (sock.State == WebSocketState.Open)
                        await sock.SendAsync(uriBytes, WebSocketMessageType.Text, true, CancellationToken.None);
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro na conexão WebSocket: {ex.Message}");
    }
    finally
    {
        // Remove a conexão que fechou
        webSockets = new ConcurrentBag<WebSocket>(webSockets.Where(ws => ws != webSocket));
    }
});

app.Run();
