using System;

namespace ClassePessoa
{
    class Program
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public double Altura { get; set; }

            public void Apresentar()
            {
                Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e {Altura: 0.00}m de altura.");
            }
        }
    }
}
