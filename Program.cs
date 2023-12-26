// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using exemploFundamentos.Models;

//classe e variável
Pessoa p1 = new Pessoa();

p1.Nome = "Teste";
p1.Idade = 2;
p1.Apresentar();


//Tipos de variáveis
//string apresentacao = "Olá, seja bem vindo";

//int quantidade = 1;

//double altura = 1.80;

//decimal preco = 1.80M;

//bool condicao = true;

//DateTime dataAtual = DateTime.Now.AddDays(5);

//Console.WriteLine(apresentacao);
//Console.WriteLine(quantidade);
//Console.WriteLine(altura);
//Console.WriteLine(altura.ToString("0.00"));
//Console.WriteLine(preco);
//Console.WriteLine(condicao);
//Console.WriteLine(dataAtual);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));


//Cast - Casting
int a = int.Parse("5");
int b = Convert.ToInt32("1");

decimal c = decimal.Parse("7");

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

//Diferença entre Parse e Convert
// Convert tratando null -> 0
// Parse tratando null -> erro


//Converter para string
int d = 5;
Console.WriteLine(d.ToString());
Console.WriteLine(Convert.ToString(d));


//Casting implicito
//Valores de int cabem dentro de double e long
int e = 9;
double f = e;
long g = e;

Console.WriteLine(f);
Console.WriteLine(g);

// A recíproca não necessariamente é verdadeira
//long h = long.MaxValue;
//int  i = h;


string m = "15-";

int n = 11;

Console.WriteLine("Try: "+ int.TryParse(m, out n));

