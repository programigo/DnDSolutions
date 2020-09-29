class Message {
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
const textInput = document.getElementById("messageText");
const whenInput = document.getElementById("when");
const chat = document.getElementById("chat");
const submitButton = document.getElementById("submitButton");
const messagesQueue = [];

//Make the button "disabled" when the page loads.
submitButton.disabled = true;

textInput.addEventListener("input", function () {
	if (!this.value) {
		submitButton.disabled = true;
	} else {
		submitButton.disabled = false;
	}
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

	let currentRowContainer = document.createElement("div");
	currentRowContainer.className = "row";

	let offsetContainer = document.createElement("div");
	offsetContainer.className = isCurrentUserMessage ? "col-md-6 offset-md-6" : "";

	let container = document.createElement("div");
	container.className = isCurrentUserMessage ? "container darker bg-primary" : "container bg-light";

	let sender = document.createElement("p");
	sender.className = isCurrentUserMessage ? "sender text-right text-white" : "sender text-left";
	sender.innerHTML = message.userName;

	let text = document.createElement("p");
	text.className = isCurrentUserMessage ? "text-right text-white" : "text-left";
	text.innerHTML = message.text;

	let when = document.createElement("span");
	when.className = isCurrentUserMessage ? "time-right text-light" : "time-left";
	var currentdate = new Date();
	when.innerHTML =
		(currentdate.getMonth() + 1) + "/"
		+ currentdate.getDate() + "/"
		+ currentdate.getFullYear() + " "
		+ currentdate.toLocaleString("en-US", { hour: "numeric", minute: "numeric", hour12: true })

	currentRowContainer.appendChild(offsetContainer);
	offsetContainer.appendChild(container);
	container.appendChild(sender);
	container.appendChild(text);
	container.appendChild(when);
	chat.appendChild(currentRowContainer);

	submitButton.disabled = true;
}
