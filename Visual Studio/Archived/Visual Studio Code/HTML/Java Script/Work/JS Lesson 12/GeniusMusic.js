class GeniusMusic
{
    constructor(el, id)
    {
        this._divResult = el;
        this._songId = id;
        this.isLoad = false;
        this.item = null;
      
        this.gromServer();
        this.render();
    }

    gromServer()
    {
        fetch("https://genius.p.rapidapi.com/songs/" + this._songId, 
        {
	"method": "GET",
	"headers": {
		"x-rapidapi-host": "genius.p.rapidapi.com",
		"x-rapidapi-key": "7e2afce0b1msh7f5c23d92a82e63p15d2e7jsn1fb4d1a13ff8"
	}
    })
    .then(response => 
    {
	return response.json();
    })
    .then(data => 
        {
            this.isLoad = true;
            this.item = data.response;
            console.log(this.item);

            let iframe = document.createElement("iframe");

                let videoId = this.item.song.media[0].url.split("=");
            
                iframe.src ="https://www.youtube.com/embed/" + videoId[1];
                this._divResult.appendChild(iframe);
        })
    .catch(err => 
    {
	console.error(err);
    });
    }


    render()
    {
        this._divResult.innerHTML += "Тут будет видно песни " + this._songId;
    }
}