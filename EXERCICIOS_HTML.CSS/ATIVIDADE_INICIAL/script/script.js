function funcao(){
    var nome = document.getElementById("nome");
    nome.value = nome.value.toUpperCase();
    var email = document.getElementById("email");
    alert("Obrigado, " + nome.value + ", entraremos em contato através de: " + email.value);
}

    