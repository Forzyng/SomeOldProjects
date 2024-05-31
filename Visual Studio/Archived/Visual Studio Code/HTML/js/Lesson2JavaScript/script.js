function max(a, b){
    //return(a . b) ? a : b;
    if(a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

function sum(a, b){
    if(
        ((a == undefined) && (b == undefined)) ||
        (isNaN(a) && isNaN(b))
        )
        return undefined;
    else
        if ((a == undefined) || isNaN(a)) 
            return b;
    else
        if((b == undefined) || isNaN(b))
            return a;
    else
        return a + b;
}



function compareValues(a, b){
    /* 
    a < b -1
    a > b = 1
    a == b = 0
    */
   if(a < b)
        return -1;
    else if(a > b)
        return 1;
    //else if(a === b)
    //    return 0;
    else
        return 0;
}

function factorial(n){
    /*
    if(n === 0)
        return 1;
    else
      return  n * f(n - 1);
    */

    if(compareValues(n, 0) == 0)
        return 1;
    else
        return  n * factorial(n - 1);
}

function average(){
    let s = 0,
        k = 0;

    for(let i = 0; i< arguments.length; i++){
        console.log(arguments[i]);
        if(!isNaN(arguments[i]))
        {
            s += arguments[i];
            k++;
        }
    }
    //for(;;); 
    if(k != 0)
        return (s / k);
    else
        return 0;
}

sayHello('user');

function sayHello(name)
{
    alert('Hello ' + name)
}

function testFotrIn(){
    for(let i in arguments){
        console.log(i + ' = ' + arguments[i]);
    }
}

function testFotrOf(){
    for(let i in arguments){
        console.log(i);
    }
}

arr1 = [];
arr2 = [1, 2, 3, 'text', 0x34, {}, [87, 24, 67], 3];

arr2[14] = 111;

console.log('arr2.lenhth = ' + arr2.length)
for(let i = 0; i < arr2.length; i++){
    console.log(i + ': ' + arr2[i])
}

arr1[0] = 'test 1';
arr1[1] = 'test 2';
arr1[2] = 'test 3';

arr1[10] = 'test 10';

arr3 = new Array();
arr4 = new Array(10);
arr5 = new Array(2, 3, 45, 2, 4, 7, 8);
delete arr5[2];

function dayOfWeek(dayId){
    let nameOfDay = '';
    switch(dayId){
        case 1:
            nameOfDay = 'понедельник';
        break;
        case 2:
            nameOfDay = 'вторник';
        break;
        case 3:
            nameOfDay = 'среда';
        break;
        case 4:
            nameOfDay = 'четверг';
        break;
        case 5:
            nameOfDay = 'пятница';
        break;
        case 6:
            nameOfDay = 'суббота';
        break;
        case 7:
            retunameOfDay = 'воскресение';
        break;
        default:
            nameOfDay = 'error';
            break;
    }
    return nameOfDay;
}
