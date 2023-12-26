using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y) //void significa vazio, ausente de valor de retorno
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            var res = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {res}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            var res = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(res, 4)}");
        }
    }
}