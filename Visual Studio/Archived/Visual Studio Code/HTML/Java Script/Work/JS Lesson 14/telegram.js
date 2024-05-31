
let token = "5003956566:AAEXjIy9WBIzJZYOoxXbSIZ2ym298MLupHY";

let chatId = "1000709329";

document.getElementById("btn").onclick = function()
{
    let msg = document.getElementById("txt").value;

    fetch("https://api.telegram.org/bot" + token + "/sendMessage?chat_id=" + chatId + "&text=" + msg)
    .then(res =>
    {
        return res.json();
    })
        .catch(err => 
            {
                console.log(err);
            })



            

  
}



let ul = document.getElementById("bootMsg");
let last_update_id = 0;

function getUpdates()
{
    fetch("https://api.telegram.org/bot" + token + "/getUpdates")
    .then(res =>
    {
        return res.json();
    })
    .then(messges =>
        {
            if(!messges.ok)
            {
                console.log(messges);
                return;
            }

console.log(messges.result);
        })
        .catch(err => 
            {
                console.log(err);
            })

            
}
let timerId = setInterval( getUpdates, 2000);
    

                    
