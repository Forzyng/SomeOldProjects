let token = "5057927228:AAF64Jv56S97Oi8x4OSM4fdtMnpGzM1iZ-k";
let chatId = "182670646"; // мой номер в телеграмм

let messagesStore = localStorage.messages;
try {
    if (messagesStore === null || messagesStore === undefined) messagesStore = [];
    else messagesStore = JSON.parse(messagesStore);
} catch (e) {
    console.log(e);
    messagesStore = [];
}

document.getElementById("btn").onclick = function () {
    let msg = document.getElementById("txt").value;

    fetch("https://api.telegram.org/bot" + token + "/sendMessage?chat_id=" + chatId + "&text=" + msg)
        .then(res => {
            console.log(res);
        })
        .catch(err => {
            console.log(err);
        })
}

let ul = document.getElementById("bootMsg");
for (let i = 0; i < messagesStore.length; i++) {
    let liMessages = document.createElement("li");
    liMessages.innerHTML = messagesStore[i].message.text;
    ul.appendChild(liMessages);
}
function render() {
    let li = document.createElement("li");
    li.innerHTML = messagesStore[messagesStore.length-1].message.text;
    ul.appendChild(li);
}

function getUpdates() {
    fetch("https://api.telegram.org/bot" + token + "/getUpdates")
        .then(res => {
            console.log(res);
            return res.json();
        })
        .then(messages => {
            if (!messages.ok) {
                console.log(messages);
                return;
            }
            let updates = messages.result;
            let last_update = updates[updates.length - 1];
            if(messagesStore[messagesStore.length - 1].update_id !== last_update.update_id){
                messagesStore.push(last_update);
                localStorage.messages = JSON.stringify(messagesStore);
                render();
            }
            console.log(messages.result);
        })
        .catch(err => {
            console.log(err);
        })
}

let timer = setInterval(getUpdates, 5000);