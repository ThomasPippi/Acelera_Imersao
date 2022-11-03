function vermelho(){
    var btn = document.getElementById("btn");
    document.body.style.background = 'red';
    alert("Alteramos a cor para vermelho.");
}

function verde(){
    var num = 1;
    var btn = document.getElementById("btn");
    document.body.style.background = 'green';
    if(num == '1'){
        alert("Compara valores sem pesar o tipo.");
    }
    if(num === '1'){
        alert("Nunca executa.");
    }else{
        alert("Compara o tipo");
    }
}

function azul(){
    numero = 1;
    var btn = document.getElementById("btn");
    document.body.style.background = 'blue';
    var x = (numero === "1") ? "Nunca executa" : "Number diferente de String com ===";
    alert(x);
}

function amarelo(){
    var btn = document.getElementById("btn");
    document.body.style.background = 'yellow';
}

function resetar(){
    var btn = document.getElementById("btn");
    document.body.style.background = '';
}