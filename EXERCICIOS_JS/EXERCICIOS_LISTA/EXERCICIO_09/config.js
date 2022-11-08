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
    var usuario = document.getElementById('usuario');
    var senha = document.getElementById('senha').value;
    var senhaV = document.getElementById('confirmaSenha').value;
    if(usuario.value != '' && senha != '' && senhaV != ''){
        document.getElementById('naoconfere_campos').id = 'conferido';
        if(senha.length >= 6 && senha.length <= 10){
            document.getElementById('naoconfere_senha').id = 'conferido';
            if(senhaV === senha){
                document.getElementById('naoconfere_confirmaSenha').id = 'conferido';
                tudoVerificado();
            }
        }
    }
    else{
        desabilita();
    }
      
    

} 