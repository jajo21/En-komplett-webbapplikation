const app = {
    home: document.querySelector('#home'),
    menu: document.querySelector('#menu'),
    mainSection: document.querySelector('main'),
    content: document.querySelector('#content'),
}

async function getData(url){
    const response = await fetch(url);
    const data = await response.json();
    return data;
}

const myCreateElement = (element, myClass, myId) => {
    const create = document.createElement(element);
    create.setAttribute('class', myClass);
    create.setAttribute('id', myId);
    return create;
}

const displayHome = () => {
    app.home.addEventListener('click', () => {
        app.content.innerText = 'Hej och välkommen till Naturhistoriska intressegruppen i Uddebo! Här kan du se mycket spännande information om Nasas olika expeditioner på Mars.';
        let btn = document.querySelector('main>button');
        if(btn !== null)
        {
            btn.remove();
        }
    });
}

const displayRovers = async () => {
    const roverData = await getData('api/rovers');
    for(let i=0; i < roverData.length; i++)
    {
        let roverDiv = myCreateElement('div', '', roverData[i].name.toLowerCase());
        roverDiv.innerText = roverData[i].name;
        app.menu.appendChild(roverDiv);
        displayRoverInfo(roverData[i]);
    }
}

const displayRoverInfo = async(roverData) => {
    let rover = document.querySelector('#' + roverData.name.toLowerCase());
    rover.addEventListener('click', async () => {
        app.content.innerText = roverData.history;
        let btn = document.querySelector('main>button');
        if(btn !== null)
        {
            btn.remove();
        }
        let photoBtn = myCreateElement('button', '', roverData.name.toLowerCase() + 'Btn');
        photoBtn.innerText = 'Foton från ' + roverData.name;
        app.mainSection.appendChild(photoBtn);
        displayRoverPhotos(roverData.name, photoBtn);
    });
}

const displayRoverPhotos = async (roverName, btn) => {
    const roverData = await getData('https://api.nasa.gov/mars-photos/api/v1/manifests/' + roverName + '/?api_key=D8ibfnfTOZIcR075vaMmFOaeVfMy116t1DuxOeAj');
    const maxDate = roverData.photo_manifest.max_date;

    const lastPhotos = await getData('https://api.nasa.gov/mars-photos/api/v1/rovers/' + roverName + '/photos?earth_date=' + maxDate + '&api_key=D8ibfnfTOZIcR075vaMmFOaeVfMy116t1DuxOeAj');
    btn.addEventListener('click', async () => {
        app.content.innerHTML = '';
        btn.remove();

        for(let i= 0; i<lastPhotos.photos.length; i++)
        {
            let photoURL = lastPhotos.photos[i].img_src;
            let roverPhoto = document.createElement('img');
            roverPhoto.src = photoURL;
            roverPhoto.alt = "Bild från rover";
            roverPhoto.classList = "roverPhoto";
            app.content.appendChild(roverPhoto);
        }
    })

}

displayHome();
displayRovers();














