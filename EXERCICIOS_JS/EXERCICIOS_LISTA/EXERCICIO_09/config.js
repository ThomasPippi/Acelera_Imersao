function cadastradoSucesso(){
    var nome = document.getElementById('usuario').value;
    alert("Obrigado " + nome + ", você foi cadastrado com sucesso!");
}

function tudoVerificado(){
    document.getElementById('verificado');
    document.getElementById("verificado").disabled = false;
}
function desabilita(){
    document.getElementById('verificado');
    document.getElementById("verificado").disabled = true;
}

var Verusuario = false;
var Versenha = false;
var Versenhasenha = false;
function verifica_usuario(){
    var nome = document.getElementById('usuario').value;
    if(nome != ''){
        Verusuario = true;
        verificando();
    }
    else{
        Verusuario = false;
        verificando();
    }
}

function verifica_senha(){
    var senha = document.getElementById('senha').value;
    if(senha.length >= 6 && senha.length <= 10){
        document.getElementById('confere_senha').className = 'conferido';
        Versenha = true;
        verificando();
    }
    else{
        document.getElementById('confere_senha').className = 'naoconferido';
        Versenha = false;
        verificando();
    }
}

function verifica_senhasenha(){
    var senhaV = document.getElementById('confirmaSenha').value;
    var senha = document.getElementById('senha').value;
    if(senhaV === senha && senha != ''){
        document.getElementById('confere_senhasenha').className = 'conferido';
        Versenhasenha = true;
        verificando();
    }
    else{
        document.getElementById('confere_senhasenha').className = 'naoconferido';
        Versenhasenha = false;
        verificando();
    }
}
function verificando(){
    if(Verusuario && Versenha && Versenhasenha){
        document.getElementById('confere_campos').className = 'conferido';
        tudoVerificado();
    }else{
        document.getElementById('confere_campos').className = 'naoconferido';
        desabilita();
    }
} 