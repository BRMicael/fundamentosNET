// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using exemploFundamentos.Common.Models;



//LISTAS
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");

//for (int contador = 0; contador < listaString.Count; contador++)
//{
//    Console.WriteLine($"posição {contador}. Valor {listaString[contador]}");
//}
//
//
//int contadorForeach = 0;
//foreach(string item in listaString)
//{
//    Console.WriteLine($"posição {contadorForeach}. Valor {item}");
//    contadorForeach++;
//}


listaString.Add("ES");
Console.WriteLine($"Numero de itens {listaString.Count}. Capacidade {listaString.Capacity}");

listaString.Remove("ES");

Console.WriteLine($"Numero de itens {listaString.Count}. Capacidade {listaString.Capacity}");


listaString.Add("PR");


Console.WriteLine($"Numero de itens {listaString.Count}. Capacidade {listaString.Capacity}");



















//ARRAYS
//int[] arrayInteiros = new int[3];
//
//arrayInteiros[0] = 22;
//arrayInteiros[1] = 44;
//arrayInteiros[2] = 32;

//int contador = 0;
//while (contador < arrayInteiros.Length)
//{
//    Console.WriteLine($"posição {contador}. Valor {arrayInteiros[contador]}");
//    contador++;
//}
//

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
//
//int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);
//
//foreach(int valor in arrayInteirosDobrado)
//{
//    Console.WriteLine(valor);
//}













//Calculadora calc = new Calculadora();
//
//calc.Somar(2,2);
//calc.Subtrair(2,2);
//calc.Multiplicar(2,2);
//calc.Dividir(2,2);
//calc.Potencia(4,2);
//
//calc.Seno(90);
//calc.Cosseno(180);
//calc.Tangente(30);
//calc.RaizQuadrada(81);


//Estruturas de repetição
//int numero = 5;
//for(int contador = 0; contador <= 10; contador++){
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}


//int contador = 0;
//while (contador <= 10)
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//    contador++; 
//
//    if (contador == 5){
//        break;
//    }
//}

//do while (verficação da condição é no final. Faça enquanto satisfazer a condição final.)
//int soma = 0, x = 0;
//do
//{
//    Console.WriteLine("Digite um número (0 para parar): ");
//    x = Convert.ToInt32(Console.ReadLine());
//    soma += x;
//} while (x != 0);
//
//Console.WriteLine("Total da soma dos números digitados: " + soma);

//bool exibirMenu = true;
////Menu
//while(exibirMenu)
//{
//    Console.Clear();
//    Console.WriteLine("Digite uma opção: ");
//    Console.WriteLine("1 - Cadastrar cliente");
//    Console.WriteLine("2 - Buscar cliente");
//    Console.WriteLine("3 - Apagar cliente");
//    Console.WriteLine("4 - Encerrar");
//
//    string opcao = Console.ReadLine();
//
//    switch(opcao)
//    {
//        case "1":
//            Console.WriteLine("Cadastro cliente");
//            break;
//        case "2":
//            Console.WriteLine("Busca cliente");
//            break;
//        case "3":
//            Console.WriteLine("Apagar cliente");
//            break;
//        case "4":
//            Console.WriteLine("Encerrar");
//            //Environment.Exit(0);
//            exibirMenu = false;
//            break;
//
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//}
//
//Console.WriteLine("Menu encerrado");
//
//
//
//