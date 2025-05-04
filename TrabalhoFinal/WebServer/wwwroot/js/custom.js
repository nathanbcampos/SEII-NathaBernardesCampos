let socket, mediaStream, captureInterval;

function startWebSocket() {
  socket = new WebSocket('wss://seii-carrinho2025.azurewebsites.net/ws');

  socket.addEventListener('open', () => console.log('WebSocket conectado'));
  socket.addEventListener('error', e => console.error('WebSocket erro', e));

  socket.addEventListener('message', ev => {
    const data = ev.data;
    // Se vier data-uri de imagem, atualiza o único <img>
    /*if (typeof data === 'string' && data.startsWith('data:image/')) {
      document.getElementById('streamImg').src = data;
    } else {
      console.log('Resposta servidor:', data);
    }*/
    //if original
    
    if (typeof data === 'string' && data.startsWith('data:image/')) {
      document.getElementById('streamImg').src = data;
      console.log('Imagem recebida do servidor!');
      alert('Imagem recebida do servidor!');
    } else {
      console.log('Resposta servidor:', data);
    }
    //If novo 
  });

  socket.addEventListener('close', () => console.log('WebSocket fechado'));
}

// Função para enviar direção (utilizada pelos botões e pelo d-pad)
function enviarDirecao(direcao) {
  if (socket && socket.readyState === WebSocket.OPEN) {
    socket.send(direcao);
    console.log('Direção enviada:', direcao);
  } else {
    console.warn('WebSocket não está aberto para enviar direção');
  }
}

// Associa cliques do D-pad (elementos com classe .control)
function bindDpadControls() {
  document.querySelectorAll('.control').forEach(el => {
    el.addEventListener('click', e => {
      e.preventDefault();
      const dir = el.dataset.direction;
      enviarDirecao(dir);
    });
  });
}

// Inicia o envio contínuo de frames da câmera
async function startCameraStream() {
  mediaStream = await navigator.mediaDevices.getUserMedia({ video: true });
  document.getElementById('localVideo').srcObject = mediaStream;

  const canvas = document.getElementById('captureCanvas');
  const ctx = canvas.getContext('2d');

  captureInterval = setInterval(() => {
    if (!socket || socket.readyState !== WebSocket.OPEN) return;
    ctx.drawImage(document.getElementById('localVideo'), 0, 0, canvas.width, canvas.height);
    canvas.toBlob(blob => {
      blob.arrayBuffer().then(buffer => socket.send(buffer));
    }, 'image/jpeg', 0.7);
  }, 200);
}

function stopCameraStream() {
  clearInterval(captureInterval);
  if (mediaStream) mediaStream.getTracks().forEach(t => t.stop());
}

// Setup inicial ao carregar a página
window.addEventListener('load', () => {
  startWebSocket();
  bindDpadControls();

  document.getElementById('startStream').addEventListener('click', startCameraStream);
  document.getElementById('stopStream').addEventListener('click', stopCameraStream);
});

// Fecha WebSocket e câmera ao sair
window.addEventListener('beforeunload', () => {
  if (socket) socket.close();
  stopCameraStream();
});

