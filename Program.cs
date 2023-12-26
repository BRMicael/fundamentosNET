// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using exemploFundamentos.Models;

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

//Condicionais
//if(letra == "a"){
//    Console.WriteLine("Vogal");
//}else if (letra == "e"){
//    Console.WriteLine("Vogal");
//}else if (letra == "i"){
//    Console.WriteLine("Vogal");
//}else if (letra == "o"){
//    Console.WriteLine("Vogal");
//}else if (letra == "u"){
//    Console.WriteLine("Vogal");
//}else{
//    Console.WriteLine("Não é uma vogal");
//}


//if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u"){
//    Console.WriteLine("Vogal");
//}else{
//    Console.WriteLine("Não é uma vogal");
//}

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}



