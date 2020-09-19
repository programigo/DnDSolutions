﻿class Message {
	constructor(username, userid, text, sendOn, recipientid) {
		this.userName = username;
		this.text = text;
		this.sendOn = sendOn;
		this.userId = userid;
		this.recipientId = recipientid;
	}
}

// userName is declared in razor page.
const username = userName;
const userid = userId;
const recipientid = recipientId;
const textInput = document.getElementById('messageText');
const whenInput = document.getElementById('when');
const chat = document.getElementById('chat');
const messagesQueue = [];

document.getElementById('submitButton').addEventListener('click', () => {
	var currentdate = new Date();
	when.innerHTML =
		(currentdate.getMonth() + 1) + "/"
		+ currentdate.getDate() + "/"
		+ currentdate.getFullYear() + " "
		+ currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })
});

function clearInputField() {
	messagesQueue.push(textInput.value);
	textInput.value = "";
}

function sendPrivateMessage() {
	let text = messagesQueue.shift() || "";
	if (text.trim() === "") return;

	let sendOn = new Date();
	let message = new Message(username, userid, text, sendOn, recipientid);
	sendMessageToHub(message);
}

function addMessageToChat(message) {
	let isCurrentUserMessage = message.userName === username;

	let container = document.createElement('div');
	container.className = isCurrentUserMessage ? "container darker" : "container";

	let sender = document.createElement('p');
	sender.className = "sender";
	sender.innerHTML = message.userName;
	let text = document.createElement('p');
	text.innerHTML = message.text;

	let when = document.createElement('span');
	when.className = isCurrentUserMessage ? "time-left" : "time-right";
	var currentdate = new Date();
	when.innerHTML =
		(currentdate.getMonth() + 1) + "/"
		+ currentdate.getDate() + "/"
		+ currentdate.getFullYear() + " "
		+ currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

	container.appendChild(sender);
	container.appendChild(text);
	container.appendChild(when);
	chat.appendChild(container);
}
