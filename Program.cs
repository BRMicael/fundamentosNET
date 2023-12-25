// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using exemploFundamentos.Models;

//classe e variável
Pessoa p1 = new Pessoa();

p1.Nome = "Teste";
p1.Idade = 2;
p1.Apresentar();

string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(apresentacao);
Console.WriteLine(quantidade);
Console.WriteLine(altura);
Console.WriteLine(altura.ToString("0.00"));
Console.WriteLine(preco);
Console.WriteLine(condicao);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
