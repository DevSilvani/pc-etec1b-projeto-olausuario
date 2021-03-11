using System;

namespace pc_etec1b_projeto_olausuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Olá, "+nome+"!");
            Console.ReadKey();
        }
    }
}
