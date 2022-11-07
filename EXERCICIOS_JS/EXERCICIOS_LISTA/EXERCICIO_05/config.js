function ativa_botao(){
    if(document.querySelectorAll("input:checked").length >= 2){
        document.getElementById("button").disabled = false;
    }
    else
    {
        document.getElementById("button").disabled = true;
    }    
}

