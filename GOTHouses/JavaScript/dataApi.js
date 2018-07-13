//gets  the valor getHouses
function getHouses() {
    
    return fetch("api/houses", { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {

                return resposta.json();

            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}
function getSingleHouse(houseId) {

    return fetch("api/houses/" + houseId, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}



function getCharacters(houseId) {

    return fetch("api/houses/" + houseId + "/characters", { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}

function getSingleCharacter(charId) {

    return fetch("api/characters/" + charId , { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}