class Genius{

    constructor(){
        this.baseId = "app_"
        this._items = []
        this._isLoad = false;
        this._error = null
        this.divResult = null
    }

    get items() {
        return this._items
    }

    set items(value){

        this._items = value;
        console.log(this._items)

        if(this._items.length > 0)
        {
            this.renderItems();
        }
        else{
            this.error = "No Result"
        }

    }

    renderItems(){
        let ul =document.createElement("ul")
        ul.style.listStyleType = "none"
        ul.style.marginLeft = "34%"
        ul.style.marginRight = "40.3%"

        console.log(this._items)
        this._items.map(item => {

            let li = document.createElement("li")
            li.style.border = "3px solid Orange"
            li.style.marginTop = "10px"
            li.style.marginBottom = "10px"
            // Создание карточки по ответу

            let title = document.createElement("h5")
            title.innerHTML = item.result.full_title;
            li.appendChild(title)

            let img = document.createElement("img")
            img.src = item.result.header_image_thumbnail_url
            img.style.width = "306px"
            li.appendChild(img)

            let video = document.createElement("div")
            let vObject = new GeniusVideo(video, item.result.id)

            li.appendChild(video)

            ul.appendChild(li)
        })
        this.divResult.innerHTML = ""
        this.divResult.appendChild(ul)
    }
    

    getFromServer(){
        fetch("https://genius.p.rapidapi.com/search?q=" +
        encodeURI(document.getElementById(this.baseId + "txtSearch").value),
            {
            "method": "GET",
            "headers": {
                "x-rapidapi-host": "genius.p.rapidapi.com",
                "x-rapidapi-key": "d84f57af08msh0223fa9c37e9f95p164b70jsnab26853d7c77"
            }
        })
        .then(response => {
            //console.log(response);
            return response.json()
        })
        .then(data => {
            console.log(data);
            this.isLoad = true
            this.items = data.response.hits;
        })
        .catch(err => {
            console.error(err);
            this.error = err
        });
    }

    doSearch(){
        this.isLoad = false
        this.getFromServer(); 
        //console.log(this.baseId + "Result")
        //document.getElementById(this.baseId + "Result").innerHTML = "Ready to Search"
    }

    render (homeElementId){

        this.baseId = "app" + "_" 

        this.baseId = homeElementId + "_"
        let txtSerch = document.createElement("input");
        txtSerch.style.borderRadius = "3px"
        txtSerch.style.marginLeft = "39%"
        txtSerch.style.marginTop = "2rem"
        txtSerch.id = this.baseId + "txtSearch"

        let btnSearch = document.createElement("button")
        btnSearch.style.marginLeft = "8px"
        btnSearch.style.backgroundColor = "rgb(255, 234, 0)"
        btnSearch.style.width = "45px"
        btnSearch.style.borderRadius = "5px"
        btnSearch.style.marginTop = "2rem"
        btnSearch.onclick = this.doSearch.bind(this)

        let divFormGroup = document.createElement( "div")
        divFormGroup.className = "input-group"

        divFormGroup.appendChild(txtSerch)
        divFormGroup.appendChild(btnSearch)

        document.getElementById(homeElementId).appendChild(divFormGroup)

        this.divResult = document.createElement("div")
        this.divResult.id = this.baseId + "Result"

        document.getElementById(homeElementId).appendChild(this.divResult)
    }

    renderLoading(){
        this.divResult.innerHTML = "Loading"
    }

    renderError(){
        this.divResult.innerHTML = "<h1>Error</h1>" + this._error
    }

    get baseId() {return this._baseId}
    set baseId(value) {this._baseId = value}

    set error(value){
        this._error = value;
        if(this._error !== null)
        {
            this.renderError()
        }
    }

    set isLoad(value){
        this._isLoad = value;
        if(!this._isLoad)
        {
            this.renderLoading()
        }
    }

}