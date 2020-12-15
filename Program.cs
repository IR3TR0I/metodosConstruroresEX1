using System;
using EX1.classes;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Seu nome :");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite Seu sobrenome" );
            string sobreNome = Console.ReadLine();
            

            Pessoa pessoa = new Pessoa(nome, sobreNome );

            

            
        }
    }
}
