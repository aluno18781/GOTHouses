//vai buscar o valor de todas as casa através de api/houses
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

//vai buscar a informação de cada casa atrvés de api/houses + id da casa pretendida
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


//vai buscar a informação todas as personagens que pertencem à mesma casa através de api/houses + id da casa pertendida /characters
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

//vai buscar a informação de uma só personagem através de api/characters/ id da personagem 
function getSingleCharacter(charId) {

    return fetch("api/characters/" + charId, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}