function mensagem(){
    var nome = document.getElementById('nome');
    var idade = document.getElementById('idade');
    if(idade.value >= 18){
    alert(nome.value + " é maior de idade.");
    }
    else{
        alert(nome.value + " é menor de idade.")
    }
}