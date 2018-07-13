//gets  the valor getHouses
function getHouses() {

    var houses = "http://localhost:26012/api/houses";

    return fetch(houses, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {

                return resposta.json();

            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}


function getCharacters(charId) {

    var character = "http://localhost:26012/api/houses/" + charId;

    return fetch(character, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}