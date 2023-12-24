using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; }
        public required int Idade { get; set; }

        //Classe -> Pessoa
        //Método -> Apresentar
        //Para usar palavras reservadas, utilizar o "@" antes da declaração
        public void Apresentar()
        {
            //Classe -> Console
            //Método -> WriteLine
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
        
    }
}