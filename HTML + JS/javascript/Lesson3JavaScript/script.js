function sayHello(){
    alert("Hello");
}

let timerId =  setTimeout(sayHello, 5000);


const ClearTimeout = document.getElementById("ClearTimeout");
if((ClearTimeout != undefined) && (ClearTimeout != null))
{
    ClearTimeout.addEventListener("click",()=> {
        if(timerId > 0)
            clearTimeout(timerId);
        console.log("Clear timeout")
        timerId = -1;
    });
}

const currentTimeElement = document.getElementById("currentTime");

function showCurrentTime(){
    let date = new Date();
    //document.getElementById("currentTime").innerHTML = data.toString();
    /*
    currentTimeElement.innerHTML = date.getHours() + ':'
                                    + date.getMinutes() + ':'
                                    + date.getSeconds();
    */
    //currentTimeElement.innerHTML = date.toLocaleTimeString();

    let h = (date.getHours() < 10) ? ("0" + date.getHours().toString()) : date.getHours().toString();
    let m = (date.getMinutes() < 10)? ("0"+date.getMinutes().toString()): date.getMinutes().toString();
    let s = (date.getSeconds() < 10)? ("0"+date.getSeconds().toString()): date.getSeconds().toString();

    currentTimeElement.innerHTML = h + ":" + m + ":" + s;
}

let timeerInt = -1;
if((currentTimeElement != undefined) && (currentTimeElement != null))
{
    timeerInt = setInterval(showCurrentTime ,1000);
}

document.getElementById("ClearInterval").addEventListener("click", ()=>
{
    if(timeerInt > 0)
        clearInterval(timeerInt);

    console.log("Clear Interval");
    timeerInt = -1;
})

let str="string test";
str = 'string test';

/*
for(let i=0; i< str.length; i++)
    console.log(str[i]);
*/

document.getElementById("chek").addEventListener("click" , ()=>{
    let login = document.getElementById("login").value;
    let pass1 = document.getElementById("pass1").value;
    let pass2 = document.getElementById("pass2").value;

    if((pass1.localeCompare(pass2) == 0) && (pass1.localeCompare(login)!=0))
        alert("Yes")
    else
        alert("No");
})


let user1={};
user1.name = "User 1";
user1.phone = "3809923456745";
user1.age = 20;
user1.address = {
    street: "s1",
    house: 10
};

user1["e-mail"] = "test@gmail";



let user2={
    name: "User 2",
    phone: "3809923456745",
    age: 18,
    address:{
        street: 's2',
        house: 11
    }
};

let user3={
    name: "User 2",
    phone: "3809923456745",
    age: 18,
    address:{
        street: 's2',
        house: 11
    },
    "e-mail": "as@gmail"
};

user3["test-user name"] = "";

delete user3["test-user name"];

if('email' in user1) 
    console.log("Yes"); 
else
    console.log("Noy");

/*

document.write("<br><h2>For of: </h2>");
for(const p of user1){
    document.write("<br><strong>" + i + "</strong>" + user1[i]);
}    
*/

document.write("<br><h2>For of: </h2>");
for(const i in user1){
    if((typeof user1[i]) == "object")
    {
        document.write("<div><strong>" + i + "</strong>:<br>" );
        for(const j in user1[i])
        {
            document.write("<strong>" + j + "</strong>: " + user1[i][j] + "<br>");
        }
        document.write("</div>");
    }
    else
    document.write("<strong>" + i + "</strong> :" + user1[i] + "<br>");
}

let user4 = new Object()
user4["name"] = "User 4";
user4.age = 20;

let yearInput = document.getElementById("yearInput");
for(let i = 1970; i <= 2021; i++)
yearInput.innerHTML += `<option value ="${i}">${i}</option>`
    
