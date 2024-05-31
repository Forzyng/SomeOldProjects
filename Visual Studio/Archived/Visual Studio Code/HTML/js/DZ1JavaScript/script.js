function hello(){
    let name = prompt("Введите имя:")
    return alert("Привет,"+ name + "!")
}

function year(){
    let year = 2021;
    const peopleyear = parseInt(prompt("Введите свой год рождения"))

    return alert("Вам " + (year - peopleyear) + " лет")
}

function Perimeter(){
    let str = parseInt(prompt("Введите сторону квадрата"))

    return alert("Периметор квадрата = " + (4 * str))
}

function Square(){
    const Pi = 3.14
    let r = parseInt(prompt("Введите радиус окружности"))

    return alert("Площадь окружности = " + (Pi * (r * r)))
}

function V(){
    let S = parseInt(prompt("Введите расстояние 'км.'"))
    let T = parseInt(prompt("Введите время 'min.'"))

    return alert("Скорость с которой нужно двигаться " + (S/T) + "км./мин." )
}

function Converter(){
    const euro = 0.88
    let dollar = parseFloat(prompt("Введите доллор"))
    
    return alert("Преобразованный доллар в евро '1доллар=0.88евро' = " + (dollar * euro) + " euro")
}

function Accommodation(){
    const mb = 820
    let gb = parseInt(prompt("Введите размер в Gb"))

    return alert("820мб. поместилось всего " +  Math.trunc(((gb * 1000)/ mb)) + " раз")
}

function res(){
    let money = parseInt(prompt("Сколько у вас деняг?"))
    let chocolate = parseInt(prompt("Цена шоколада"))
    let col = Math.trunc((money/chocolate))
    let remainder = money-(col * chocolate)

    return alert("Количество плиток шоколада которые вы можете позволить " + col + " ,у вас осталось денег " + remainder)
}

function coup(){
    let cou = parseInt(prompt('Введите трёх значное число'))
    let res = 0
    while(cou)
    {
        res = res * 10 + cou % 10
        cou = Math.floor(cou/10)
    }

    return alert(res)
}

function def(){
    let num = parseInt(prompt("Введите число"))

    if((num % 2) === 0)
        return alert("Чётное")
    else
        return alert("Нечётное")
}

def()
