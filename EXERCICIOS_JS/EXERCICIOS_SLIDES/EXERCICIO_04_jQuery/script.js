function calcular(){
    var num1 = parseInt(document.getElementById("num1").value);
    var num2 = parseInt(document.getElementById("num2").value);
    var soma = num1 + num2;


    $(document).ready(function(){
        if(parseInt(soma) % 2 == 0){
        $("#btn").click(function(){
          $(this).css("background-color", "blue");
          alert(soma);
        });}
        else if(parseInt(soma) % 2 != 0){
            $("#btn").click(function(){
            $(this).css("background-color", "red");
            alert(soma);
            });
        }
      })


}
















/*function calcular(){

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
}*/