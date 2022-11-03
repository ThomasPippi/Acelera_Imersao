function calcular(){
    var num1 = parseInt(document.getElementById("num1").value);
    var num2 = parseInt(document.getElementById("num2").value);
    var soma = num1 + num2;

if(parseInt(soma) % 2 == 0){

    btn.style.color = "red";
    alert(soma)
}
else{
    btn.style.color = "blue";
    alert(soma)
}
}