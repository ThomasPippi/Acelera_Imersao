function textoPBranco(){
    var para = document.getElementById("paragrafo");
    para.style.color = 'white';
}

function textoPPreto(){
    var para = document.getElementById("paragrafo");
    para.style.color = 'black';
}

function fundoPBranco(){
    var fundo = document.getElementById("paragrafo");
    fundo.style.backgroundColor = 'white';
}

function fundoPPreto(){
    var fundo = document.getElementById("paragrafo");
    fundo.style.backgroundColor = 'black';
}
tamanho = 1;
function aumentaFont(){
    var letra = document.getElementById("paragrafo");
    tamanho++;
    letra.style.fontSize = tamanho + 'rem';

}
function diminuiFont(){
    var letra = document.getElementById("paragrafo");
    tamanho--;
    letra.style.fontSize = tamanho + 'rem';
}

function maiuscula(){
    var texto = document.getElementById("paragrafo");
    texto.style.textTransform = 'uppercase';
}

function minuscula(){
    var texto = document.getElementById("paragrafo");
    texto.style.textTransform = 'lowercase';
}
function resetar(){
    var fundo = document.getElementById("paragrafo");
    fundo.style.backgroundColor = '';
}