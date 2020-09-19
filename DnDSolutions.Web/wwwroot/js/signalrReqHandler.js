var connection = new signalR.HubConnectionBuilder()
    .withUrl('/Messages/Index')
    .build();

connection.on('receiveMessage', addMessageToChat);

connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendMessageToHub(message) {
    connection.invoke('sendPrivateMessage', message);
}