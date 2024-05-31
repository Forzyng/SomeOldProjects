$(document).ready(function(){
    $.getJSON("current.city.list.json" , function(dats){
        $("select").on("change", function(){
            var out = '';
            for(var key in data){
                if(data(key).country == $("select option:selected").val()){
                    out = `<p value='${data[key].id}'>${data[key].name}</p>`
                }
            }
            $('#city').html(out)
            $("#city p").on("click", function(){
                $.get(
                    "htttp://api.openweathermap.org/data/2.5/weather",
                    {
                        "id" : $(this).attr("value"),
                        "appid": "331e48385f60e94d4330495d22577f5a"
                    },
                    function(data){
                        let out = "";
                        out += "Погода: <b>" + data.wether[0].nain + "</b><br>"
                        uot += "<p style='text-aling:center'><img src='htttp://api.openweathermap.org/img/w/"+ data.wether[0].icon + ".png'></p>"

                        out += "Температура: <b>"+Math.round(data.main.temp-273)+"&#176;C</b><br>"
                        console.log(data.main)
                        $("#weather").html(out)
                    }
                )
            })
        })
    })
})