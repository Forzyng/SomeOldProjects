function range(){
    let num1 = parseFloat(prompt("Введите от какого числа"));
    let num2 = parseFloat(prompt("Введите до какого числа"));
    let sum = 0;
    for(let i = num1; i <= num2; i++)
    {
        sum += i;
    }
    return alert("Сумма= " + sum)
}


function divider(){
    let num1 = parseFloat(prompt("Число 1"));
    let num2 = parseFloat(prompt("Число 2"));

    if(num1 === 0)
        return alert("наибольший общий делитель= " + num2)

    while(num2 != 0)
    {
        if(num1 > num2)
            num1 = num1 - num2;
        else
            num2 = num2 - num1;
    }

    return alert("наибольший общий делитель= " + num1)
}


function diviberThisNumber(){
    let num1 = parseInt(prompt("Число= "));

    for(let i = 1; i <= num1+1; i++)
    {
        if(num1 % i === 0)
        {
            alert("Делитель= " + i)
        }
    }

}


function numberOfDigits(){
    let num1 = prompt("Число= ");
    let c = 1;
    while(c < num1.length)
    {
        c++;
    }

    alert("Количество цифер в числе= " + c)
    return 0
}


function chek(){
    let q1 = 0 , q2 = 0, q3 = 0;

    let num1;

    for(let i = 0; i < 10; i++)
    {
        num1 = parseInt(prompt("Введите " + (i+1) + " чисел= "))

        if(num1 > 0)
        {
            q1++;
        }else
        if(num1 === 0)
        {
            q3++;
        }else
        if(num1 < 0)
        {
            q2++;
        }
    }

    alert("Количество положительных: " + q1);
    
    alert("Количество отрицательных: " + q2);
     
    alert("Количество нулей: " + q3);

    return 0;
}


function calculator(){
    do{
        let num1 = parseFloat(prompt("Число 1"));
        let num2 = parseFloat(prompt("Число 2"));
        let num3 = prompt("Знак('+', '-', '*', '/')");

        switch(num3)
        {
            case '+':
                alert(num1 + num2)
            break;
            case '-':
                alert(num1 - num2)
            break;
            case '*':
                alert(num1 * num2)
            break;
            case '/':
                alert(num1 / num2)
            break;
        }

    }while(confirm('Хотите ли вы решить еще один пример?'))

}


function move(){
    let num1 = prompt("Введите числе");
    let num2 = prompt("Сколько сдвинуть разрядов?");

    return alert(num1.slice(num2) + num1.slice(0 , num2));
}


function weeks(){
    const days = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота', 'Воскресенье'];
    let nextDay = 0;

    while(confirm('[' + days[nextDay] + '] Идём дальше?')){
        nextDay = (nextDay + 1) % days.length
    }
}


function multiplicationTable(){
    for(let i = 2; i <= 9; i++)
    {
        document.write("<div style='font-family: Arial, Helvetica, sans-serif; float: left; width: 70px;'>"); 
        for(let j = 1; j <= 10; j++)
        {
            document.write(i + '*' + j + '=' + (i*j) + "<br>")
        }
        document.write ("</div>");
    }
}


function GuessTheNumber(){
    let n = 50, half = 25, i = 1, ch;
    while(true)
    {
        let num1 = prompt("Ваше число больше меньше или равно('<', '>', '=') " + Math.trunc(n) + '?');
        
        if(num1 == '=')
        {
            alert('Ваше число ' + Math.trunc(n))
        }else if(num1 == '>')
        {
            n = n + half;
        }else if(num1 == '<')
        {
           n = n - half;
        }
        if(n > 100 || n < 1)
        {
            return alert('Не удалось отгадать:(')
        }
        half = half / 2 + 1;
    }
}


GuessTheNumber()