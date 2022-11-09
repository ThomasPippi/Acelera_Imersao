function pessoaCPF(){
    var pessoa = document.getElementById('trocapessoa');
    document.getElementById("pessoa").disabled = false;
    pessoa.innerText = 'CPF:';
    document.getElementById('nascimento').style.display = 'inline';
}
function pessoaCNPJ(){
    var pessoa = document.getElementById('trocapessoa');
    pessoa.innerText = 'CNPJ:';
    document.getElementById('nascimento').style.display = 'none';    
}