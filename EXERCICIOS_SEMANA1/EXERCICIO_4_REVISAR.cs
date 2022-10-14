using System;
class Exercicio_4 {
  static void Main() {
    int numero = 0, lingua = 1; //Português=1 Inglês=2 Espanhol=3.
    string trad = "";
    Console.WriteLine("Número entre 0 e 9 correspondendo a sua escrita.");
    Console.WriteLine("\nEscolha o número a ser convertido: ");
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha o idioma: \n 1 - Português \n 2 - Inglês \n 3 - Espanhol");
    lingua = int.Parse(Console.ReadLine());
    if((numero >= 1 && numero <= 9) && (lingua >= 1 && lingua <= 3)){
        switch(lingua){
            case 1:
                switch(numero){
                    case 0:
                    trad = " - Zero";
                    break;
                    case 1:
                    trad = " - Um";
                    break;
                    case 2:
                    trad = " - Dois";
                    break;
                    case 3:
                    trad = " - Três";
                    break;
                    case 4:
                    trad = " - Quatro";
                    break;
                    case 5:
                    trad = " - Cinco";
                    break;
                    case 6:
                    trad = " - Seis";
                    break;
                    case 7:
                    trad = " - Sete";
                    break;
                    case 8:
                    trad = " - Oito";
                    break;
                    case 9:
                    trad = " - Nove";
                    break;
                }break;
                case 2:
                switch(numero){
                    case 0:
                    trad = " - Zero";
                    break;
                    case 1:
                    trad = " - One";
                    break;
                    case 2:
                    trad = " - Two";
                    break;
                    case 3:
                    trad = " - Three";
                    break;
                    case 4:
                    trad = " - Four";
                    break;
                    case 5:
                    trad = " - Five";
                    break;
                    case 6:
                    trad = " - Six";
                    break;
                    case 7:
                    trad = " - Seven";
                    break;
                    case 8:
                    trad = " - Eight";
                    break;
                    case 9:
                    trad = " - Nine";
                    break;
                }break;
                case 3:
                switch(numero){
                    case 0:
                    trad = " - Cero";
                    break;
                    case 1:
                    trad = " - Uno";
                    break;
                    case 2:
                    trad = " - Dos";
                    break;
                    case 3:
                    trad = " - Tres";
                    break;
                    case 4:
                    trad = " - Cuatro";
                    break;
                    case 5:
                    trad = " - Cinco";
                    break;
                    case 6:
                    trad = " - Seis";
                    break;
                    case 7:
                    trad = " - Siete";
                    break;
                    case 8:
                    trad = " - Ocho";
                    break;
                    case 9:
                    trad = " - Nueve";
                    break;
                }break;
                
        }
        Console.Write(numero+trad);
    }else{
        Console.Write("Número Inválido!");
    } //ERRO NA EXECUÇÃO, ENTRANDO NA CONDIÇÃO MESMO SENDO MAIOR QUE 9
  }
}