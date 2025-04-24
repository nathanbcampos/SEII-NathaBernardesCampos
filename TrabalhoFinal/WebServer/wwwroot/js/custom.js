let socket;

function iniciarWebSocket() {
  socket = new WebSocket('wss://seii-carrinho2025.azurewebsites.net/ws');

  socket.onopen = function() {
      console.log('Conexão WebSocket estabelecida.');
  };

  socket.onmessage = function(event) {
      console.log('Mensagem recebida do servidor: ' + event.data);
  };

  socket.onclose = function() {
      console.log('Conexão WebSocket fechada.');
  };
}

function enviarDirecao(direcao) {
  if (socket && socket.readyState === WebSocket.OPEN) {
      socket.send(direcao);
      console.log('Mensagem enviada: ' + direcao);
  } else {
      console.log('WebSocket não está aberto.');
  }
}

document.querySelectorAll('.control').forEach(function(control) {
    control.addEventListener('click', function(event) {
        event.preventDefault(); 
        const direcao = control.getAttribute('data-direction');
        enviarDirecao(direcao);
    });
});

window.onload = iniciarWebSocket;
