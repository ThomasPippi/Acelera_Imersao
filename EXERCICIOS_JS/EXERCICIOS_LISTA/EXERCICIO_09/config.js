function cadastradoSucesso(){
    alert("Usuário Cadastrado com Sucesso");
}

function tudoVerificado(){
    document.getElementById('verificado');
    document.getElementById("verificado").disabled = false;
}
function desabilita(){
    document.getElementById('verificado');
    document.getElementById("verificado").disabled = true;
}
function verificando(){
    var usuario = document.getElementById('usuario').value;
    var senha = document.getElementById('senha').value;
    var senhaV = document.getElementById('confirmaSenha').value;
    if(usuario != '' && senha != '' && senhaV != ''){
        document.getElementById('confere_campos').className = 'conferido';
    }
    else{
        desabilita();
    }
    if(senha.length >= 6 && senha.length <= 10){
        document.getElementById('confere_senha').className = 'conferido';
    }
    else{
        document.getElementById('confere_senha').className = 'naoconferido';
    }
      
    if(senhaV === senha && senha != ''){
        document.getElementById('confere_senhasenha').className = 'conferido';
    }
    else{
        document.getElementById('confere_senhasenha').className = 'naoconferido';
    }
    

} 