

let token = "5087021463:AAFzDrwzm4xpXSVArfbVBZcWbVH59pUyHSk"
let chatId = '580223379' // Мой номер в сети телеграм 
let update_id = "823010120"

let messagesStore = localStorage.messages;

try 
{
    if (messagesStore === null || messagesStore === undefined) 
        messagesStore = [];
    else 
        messagesStore = JSON.parse(messagesStore);
} catch (e) {
    console.log(e);
    messagesStore = [];
}

document.getElementById("btn").onclick = function(){

    let msg = document.getElementById("txt").value;

    fetch("https://api.telegram.org/bot" + token + "/sendMessage?chat_id=" + chatId + "&text=" + msg)
        .then(res=>{
            console.log(res)
        })
        .catch(err=>{
                console.log(err);
            })
}

let ul = document.getElementById("botMsg")

for (let i = 0; i < messagesStore.length; i++) {
    let liMes = document.createElement("li");
    liMes.innerHTML = messagesStore[i].message.text;
    ul.appendChild(liMes);
}

function render() {
    let li = document.createElement("li");
    li.innerHTML = messagesStore[messagesStore.length-1].message.text;
    ul.appendChild(li);
}

let last_update_id = 0;

function update(){
    fetch("https://api.telegram.org/bot" + token + "/getUpdates")
        .then(res=>{
            console.log(res)
            return res.json();
        })
        .then(massages=>{
            if (!massages.ok) {
                console.log(massages);
                return;
            }

            let updates = massages.result;
            last_update_id = updates[updates.length - 1];

            if(messagesStore[messagesStore.length - 1] !== last_update_id){
                messagesStore.push(last_update);
                localStorage.messages = JSON.stringify(messagesStore);
                render();
            }

            console.log(massages.result);
        })
        .catch(err=>{
            console.log(err);
        })
}

let timer = setInterval(update, 10000);