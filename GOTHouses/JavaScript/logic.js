document.addEventListener("DOMContentLoaded", function main() {
    init();
    //barraProcura ();
});


function init() {
    screenHouses();
}



//função que permite transitar do div "houses" para o div "singleHouse" atribuindo a class hide ao div "houses" e removendo a mesma class ao div "singleHouse"
function houseToSingleHouse() {
    var divHouses = document.getElementById("houses");
    var divSingleHouse = document.getElementById("singleHouse");
    divHouses.classList.add("hide");
    divSingleHouse.classList.remove("hide");
}

//função que permite transitar do div "singleHouse" para o div "singleCharacter" atribuindo a class hide ao div "singleHoues" e removendo a mesma class ao div "singleCharacter"
function singleHouseToCharacter() {
    var divSingleHouse = document.getElementById("singleHouse");
    var divSingleCharacter = document.getElementById("singleCharacter");
    divSingleHouse.classList.add("hide");
    divSingleCharacter.classList.remove("hide");
}


//função para mostrar todas as casa
function showHouses(houses) {
    for (var i = 0; i < houses.length; i++) {
        var house = houses[i];

        //div que recebe todas as fotos e nomes das casas dentro do div "divHouseContainer"
        var divHouses = document.getElementById("houses");

        //contentor que recebe o nome e a foto de uma casa
        var divHouseContainer = document.createElement("div");
        divHouseContainer.className = "divHouse";


        var houseName = document.createElement("h3");
        houseName.textContent = house.Name;
        divHouseContainer.appendChild(houseName);

        var houseSymbol = document.createElement("img");
        houseSymbol.src = house.Symbol;
        houseSymbol.className = "img-House";
        divHouseContainer.appendChild(houseSymbol);

        //envia o divHouseContainer para dentro do divHouses
        divHouses.appendChild(divHouseContainer);

        //função que permite abrir o div de uma só casa através do clique no nome desta
        houseSymbol.setAttribute('data-idHouse', house.Id);
        houseSymbol.onclick = getId => {
            var idHouse = getId.target.getAttribute('data-idHouse', house.Id);
            screenSingleHouse(idHouse);
            houseToSingleHouse();
        }

        houseName.setAttribute('data-idHouse', house.Id);
        //função que permite abrir o div de uma só casa através do clique na imagem desta
        houseName.onclick = getId => {
            var idHouse = getId.target.getAttribute('data-idHouse', house.Id);
            screenSingleHouse(idHouse);
            houseToSingleHouse();
        }

    }

}

async function showSingleHouse(houses) {

    //div que ira conter toda a informação da casa
    var divSingleHouse = document.getElementById("singleHouse");

    // div que recebe o nome e imagem da casa
    var divHouseContainer = document.createElement("div");
    divHouseContainer.className = "divHouseSingle";

    var houseName = document.createElement("h3");
    houseName.textContent = houses.Name;
    divHouseContainer.appendChild(houseName);

    var houseSymbol = document.createElement("img");
    houseSymbol.src = houses.Symbol;
    houseSymbol.className = "img-House";
    divHouseContainer.appendChild(houseSymbol);

    //envia o divHouseContainer para dentro do divSingleHouse
    divSingleHouse.appendChild(divHouseContainer);
    var houseDescrip = document.createElement("p");

    houseDescrip.textContent = houses.Description;
    divSingleHouse.appendChild(houseDescrip);

    //permite receber o array de characters 
    let array = await getCharacterByHouseID(houses.Id);
    for (var i = 0; i < array.length; i++) {
        var character = array[i];

        var charWithPhoto = document.createElement("div");
        charWithPhoto.className = "charWithPhoto";

        var charPhoto = document.createElement("img");
        charPhoto.className = "image";
        charPhoto.src = character.Photo;
        charWithPhoto.appendChild(charPhoto);

        var middle = document.createElement("div");
        middle.className = "middle";

        var charName = document.createElement("text");
        charName.className = "text";

        charName.textContent = character.Name;
        middle.appendChild(charName);

        charWithPhoto.appendChild(middle);
        divSingleHouse.appendChild(charWithPhoto);

        //função que permite abrir o div de uma personagem através do clique no nome desta
        charName.setAttribute('data-idChar', character.Id);
        charName.onclick = getId => {
            var idChar = getId.target.getAttribute('data-idChar', character.Id);
            screenSingleCharacter(idChar);
            singleHouseToCharacter();
        }

        //função que permite abrir o div de uma personagem através do clique na fotografia desta
        charPhoto.setAttribute('data-idChar', character.Id);
        charPhoto.onclick = getId => {
            var idChar = getId.target.getAttribute('data-idChar', character.Id);
            screenSingleCharacter(idChar);
            singleHouseToCharacter();
        }

    }


}

//função que apresenta a informação de uma só personagem
function showSingleCharacter(charId) {
    var divSingleCharacter = document.getElementById("singleCharacter");

    var singleCharWithPhoto = document.createElement("div");
    singleCharWithPhoto.className = "singleCharWithPhoto";

    var charName = document.createElement("h3");
    charName.className = "singleName";
    charName.textContent = charId.Name;
    singleCharWithPhoto.appendChild(charName);

    var charPhoto = document.createElement("img");
    charPhoto.className = "singlePhoto";
    charPhoto.src = charId.Photo;
    singleCharWithPhoto.appendChild(charPhoto);

    divSingleCharacter.appendChild(singleCharWithPhoto);

    var charDescrip = document.createElement("p");
    charDescrip.className = "charDescrip";
    charDescrip.textContent = charId.Description;
    divSingleCharacter.appendChild(charDescrip);

    var charVideo = document.createElement("iframe");
    charVideo.src = charId.Video;
    divSingleCharacter.appendChild(charVideo);



}

function screenHouses() {
    return getHouses()
        .then(function (houses) {
            showHouses(houses);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function getCharacterByHouseID(houseId) {
    return getCharacters(houseId)
        .then(function (houses) {
            return houses;
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function screenSingleHouse(houseId) {
    return getSingleHouse(houseId)
        .then(function (houses) {
            showSingleHouse(houses);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function screenSingleCharacter(charId) {
    return getSingleCharacter(charId)
        .then(function (houses) {
            showSingleCharacter(houses);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}