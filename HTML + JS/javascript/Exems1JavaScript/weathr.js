//331e48385f60e94d4330495d22577f5a - key 
//api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key} - link 

let tempBlock = document.querySelector("#temp")
let humidityBlock = document.querySelector("#humidity")
let visibilityBlock = document.querySelector("#visibility")
let windBlock = document.querySelector("#wind")

let imgWeatherBlock = document.querySelector("#imgWeather")

let cityBlock = document.querySelector("#city")
let localDate = document.querySelector("#local-date")
let searchInp = document.querySelector(".search")

let img = document.createElement("img")

let city = "Mykolaiv"

setInterval(() => {
    let date = new Date;

    let h = (date.getHours() < 10) ? ("0" + date.getHours().toString()) : date.getHours().toString();
    let m = (date.getMinutes() < 10)? ("0"+date.getMinutes().toString()): date.getMinutes().toString();
    let s = (date.getSeconds() < 10)? ("0"+date.getSeconds().toString()): date.getSeconds().toString();

    localDate.textContent = h + ":" + m + ":" + s
}, 1000)

function SearchCity(){
    let value = searchInp.value
    if(!value)
        return false;
    city = value
    imgWeatherBlock.appendChild(img).remove()
    Weather()
    searchInp.value = ""
}

document.addEventListener("keydown", e=>{
    if(e.key === "Enter"){
        SearchCity()
    }
})

document.getElementById("btmSearch").onclick = function(){
    SearchCity()
}

function Weather(){

    fetch(`http://api.openweathermap.org/data/2.5/weather?q=${city}&appid=331e48385f60e94d4330495d22577f5a`)
        .then(resp => {
                return resp.json()
            })
        .then(data =>{
            tempBlock.textContent = `Temperature: ${temperature()}°`
            humidityBlock.textContent = `Humidity: ${hum()}%`
            cityBlock.textContent = `City: ${data.name}`
            //imgWeatherBlock.textContent = ImgWeather()
            visibilityBlock.textContent = `Visibility: ${Visibility()} km.`
            windBlock.textContent = `Wind speed: ${Wind()} km/h`

            img.src = 'https://openweathermap.org/img/w/'+data.weather[0].icon+'.png'
            img.style.widows = "150px"
            imgWeatherBlock.appendChild(img)
           

            function temperature(){
                let getTemp = data.main.temp
                let tempC = Math.floor(getTemp) - 273
                return tempC
            }

            function hum(){
                let getHumidite = data.main.humidity
                let humidityC = Math.floor(getHumidite)
                return humidityC
            }

            function Visibility(){
                let getvisibility = data.visibility
                let visibilityC = getvisibility / 1000
                return visibilityC
            }

            function Wind(){
                let getWind = data.wind.speed
                let windC = getWind / (1000/3600)
                return windC.toFixed(2)
            }

            //updateDate.textContent = `Update time: ${date.getHours()}:${date.getMinutes()}:${date.getSeconds()}`

            console.log("перезапуск")

        })
        .catch(err=>{
            console.error(err)
            this.error = err
            alert("City not found")
            city = "London"
            Weather()
            searchInp.value = ''
        })

}

Weather();

setInterval(()=>{
    //Weather().remove()
    Weather()
}, 5000)