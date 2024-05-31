function age(){
    let 
        localA = parseFloat(document.getElementById("num1").value);
         console.log(localA);

    if(localA >= 0 && localA <= 2)
        document.getElementById("res").value = "ребенoк";
    else if(localA >= 12 && localA <= 18)
        document.getElementById("res").value = "подростoк";
    else if(localA >= 18 && localA <= 60)
        document.getElementById("res").value = "взрослый";
    else if(localA > 60)
        document.getElementById("res").value = "пенсионер";
}

function num(){
    let 
    localA = parseFloat(document.getElementById("num1").value);
     console.log(localA);

    switch(localA){
        case 1:
            document.getElementById("res").value = "!";
        break;
        case 2:
            document.getElementById("res").value = "@";
        break;
        case 3:
            document.getElementById("res").value = "#";
        break;
        case 4:
            document.getElementById("res").value = "$";
        break;
        case 5:
            document.getElementById("res").value = "%";
        break;
        case 6:
            document.getElementById("res").value = "^";
        break;
        case 7:
            document.getElementById("res").value = "&";
        break;
        case 8:
            document.getElementById("res").value = "*";
        break;
        case 9:
            document.getElementById("res").value = "()";
        break;
    }
}

function verify(){
    let 
    localA = parseInt(document.getElementById("num1").value);
     console.log(localA);

    if(localA[0] === localA[1] || localA[0] === localA[2] || localA[2] === localA[1])
        document.getElementById("res").value = "Есть схожите цифры";
    else
        document.getElementById("res").value = "Нет схожих цифры";
}

function leap(){
    let 
    localA = parseInt(document.getElementById("num1").value);
     console.log(localA);

    if((localA % 4 === 0) || (localA % 400 === 0) && (localA % 100 != 0))
        document.getElementById("res").value = "Высокосный год";
    else
        document.getElementById("res").value = "Не высокосный год";
}

function palindrome(){
    let 
    localA = document.getElementById("num1").value;
    console.log(localA);

    if(localA === localA.split('').reverse().join(''))
        document.getElementById("res").value = "Является палиндромом";
    else
        document.getElementById("res").value = "Не является палиндромом";
}

function currency(){
    const EUR = 0.88
    const UAN = 6.39
    const AZN = 1.70
    
    let curr = prompt("Введите название валюты в которую вы хотите перевести")
    let 
    localA = document.getElementById("num1").value;
    console.log(localA);
    switch(curr)
    {
        case 'EUR':
            document.getElementById("res").value = "EUR" + (EUR * localA);
            break;
        case 'UAN':
            document.getElementById("res").value = "UAN" + (UAN * localA);
            break;
        case 'AZN':
            document.getElementById("res").value = "AZN" + (AZN * localA);
            break;
    }
}

function discount(){
    let 
    localA = document.getElementById("num1").value;
    console.log(localA);

    if(localA >= 200 && localA < 300)
        document.getElementById("res").value = (localA / 10 * 97) + " - 3%";
    else
    if(localA >= 300 && localA < 500)
        document.getElementById("res").value = (localA / 10 * 95) + " - 5%";
    else
    if(localA >= 500)
        document.getElementById("res").value = (localA / 10 * 93) + " - 7%";
}

function place(){ 
    localA = parseInt(document.getElementById("num1").value);
    console.log(localA);
    localB = parseInt(document.getElementById("num2").value);
    console.log(localB);

    if(localA > localB)
    {
        if(localA % 4 === 0)
        {
            document.getElementById("res").value = "Можно вписать";
        }
        else{
            document.getElementById("res").value = "Нельзя";
        }
    }
    else{
        document.getElementById("res").value = "Нельзя";
    }

}

function vop(){
    let cap = prompt('Кто был отцом Люка Скайуокера? 1 - Дарт-Вэйдер 2 - Хан Соло 3 - Император Палпатин');
    let cur = prompt('Кто съел моё печенье? 1 - Я 2 - Ты 3 - Он');
    let cou = prompt('Это правда, что не кто не любит оливки? 1 - Нет 2 - Да 3 - Я их люблю');
    let sс = 0;

    if (cap == 1)
        sc += 2;

    if (cur == 2)
        sc += 2;

    if (cou == 2)
        sс += 2;

    alert('Количество балов-' + sc);
}

function data(){
    localA = document.getElementById("num1").value;
    console.log(localA);
    localA = localA.split('-');

    let oldDate = new Date(localA[2], localA[1]-1, localA[0]); 
    oldDate.setDate(oldDate.getDate()+1);

    document.getElementById("res").value = oldDate;
}

document.getElementById("btnRes").addEventListener("click", data);