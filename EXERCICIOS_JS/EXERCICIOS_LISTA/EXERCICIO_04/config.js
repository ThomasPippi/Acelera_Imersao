function esconder(){
    var texto = document.getElementById('esconde');
    var botao = document.getElementById('btn_esconder');
      switch(botao.innerText){
        case "Esconder":
            texto.style.visibility = 'hidden';
            botao.innerText = 'Mostrar';
            break;
        case "Mostrar":
            texto.style.visibility = 'visible';
            botao.innerText = 'Esconder';
            break;
    }
}


