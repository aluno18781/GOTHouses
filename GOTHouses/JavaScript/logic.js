document.addEventListener("DOMContentLoaded", function main() {
    init();
    //barraProcura ();
});


function init() {
    screenHouses();
    //screenSingleHouse(1);
    //screenCharacters(1);
    //screenSingleCharacter(charId);
}

//serve para esconder o div
//divHouses.classList.add("hide");

//serve para mostrar o div
//divHouses.classList.remove("hide");


function houseToSingleHouse() {
    var divHouses = document.getElementById("houses");
    var divSingleHouse = document.getElementById("singleHouse");
    divHouses.classList.add("hide");
    divSingleHouse.classList.remove("hide");
}

function singleHouseToCharacter() {
    var divSingleHouse = document.getElementById("singleHouse");
    var divSingleCharacter = document.getElementById("singleCharacter");
    divSingleHouse.classList.add("hide");
    divSingleCharacter.classList.remove("hide");
}



function showHouses(houses) {
    for (var i = 0; i < houses.length; i++) {
        var house = houses[i];

        var divHouseContainer = document.createElement("div");
        divHouseContainer.className = "divHouse";
        var divHouses = document.getElementById("houses");
        var houseName = document.createElement("h3");
        houseName.textContent = house.Name;
        divHouseContainer.appendChild(houseName);

         var houseSymbol = document.createElement("img");
        houseSymbol.src = house.Symbol;
        houseSymbol.className = "img-House";
        divHouseContainer.appendChild(houseSymbol);

        divHouses.appendChild(divHouseContainer);
        


        houseName.setAttribute('data-idHouse', house.Id);
        //funtion que vai abrir a casa com as respectivas personagens
        houseName.onclick = getId => {
            var idHouse = getId.target.getAttribute('data-idHouse', house.Id);
            screenSingleHouse(idHouse);
            houseToSingleHouse();
        }

        //apresentar cada fotografia de cada categoria
       
    }
    
}

async function showSingleHouse(houses) {
    var divSingleHouse = document.getElementById("singleHouse");


        var houseName = document.createElement("h3");
        houseName.textContent = houses.Name;
        divSingleHouse.appendChild(houseName);
    
        var houseSymbol = document.createElement("img");
        houseSymbol.src = houses.Symbol;
        houseSymbol.className = "img-House";
        divSingleHouse.appendChild(houseSymbol);

        var houseDescrip = document.createElement("p");
        houseDescrip.textContent = houses.Description;
        divSingleHouse.appendChild(houseDescrip);

        //permite receber o array de characters 
        let array = await getCharacterByHouseID(houses.Id);
        console.log(array);
        for (var i = 0; i < array.length; i++) {
            var character = array[i];

            var charPhoto = document.createElement("img");
            charPhoto.src = character.Photo;
            divSingleHouse.appendChild(charPhoto);
            
            var charName = document.createElement("h5");
            charName.textContent = character.Name;
            divSingleHouse.appendChild(charName);

            charName.setAttribute('data-idChar', character.Id);
            //funtion que vai abrir a role com os respectivos heroes
            charName.onclick = getId => {
                var idChar = getId.target.getAttribute('data-idChar', character.Id);
                screenSingleCharacter(idChar);
                singleHouseToCharacter();
            }

        }
        
    
}

 function showCharacters(houses) {
    for (var i = 0; i < houses.length; i++) {
        var character = houses[i];

        var divCharacter = document.getElementById("houseCharacters");

        var charPhoto = document.createElement("img");
        charPhoto.src = character.Photo;
        divCharacter.appendChild(charPhoto);
        
        var charName = document.createElement("h5");
        charName.textContent = character.Name;
        divCharacter.appendChild(charName);
        
    }
    
 }

function showSingleCharacter(charId) {
    var divSingleCharacter = document.getElementById("singleCharacter");

    var charName = document.createElement("h5");
    charName.textContent = charId.Name;
    divSingleCharacter.appendChild(charName);

    var charPhoto = document.createElement("img");
    charPhoto.src = charId.Photo;
    divSingleCharacter.appendChild(charPhoto);

    var charDescrip = document.createElement("p");
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

function screenCharacters(houseId) {
    return getCharacters(houseId)
        .then(function (houses) {
            showCharacters(houses);
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