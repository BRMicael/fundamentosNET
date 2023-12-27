using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Caminho lógico != Caminho físico
namespace exemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }

        //Classe -> Pessoa
        //Método -> Apresentar
        //Para usar palavras reservadas, utilizar o "@" antes da declaração
        public void Apresentar()
        {
            //Classe -> Console
            //Método -> WriteLine
            //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");

            //"Quebrando" o camando
            Console.WriteLine($"Olá, meu nome é {Nome}, e " +
            $"tenho {Idade} anos");

            //Para quebrar a linha usar o /n
        }
        
    }
}