function pessoaCPF(){
    var pessoa = document.getElementById('trocapessoa');
    document.getElementById("pessoa").disabled = false;
    pessoa.innerText = 'CPF:';
    document.getElementById('data_nasc').style.display = 'inline';
    document.getElementById('data').style.display = 'inline';
}
function pessoaCNPJ(){
    var pessoa = document.getElementById('trocapessoa');
    pessoa.innerText = 'CNPJ:';
    document.getElementById('data_nasc').style.display = 'none';
    document.getElementById('data').style.display = 'none';
}