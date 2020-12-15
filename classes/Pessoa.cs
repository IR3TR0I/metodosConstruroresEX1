using System;
namespace EX1.classes
{
    public class Pessoa
    {
        public string primeiroNome;

        public string sobreNome;



        public Pessoa(string primeiroNome, string sobreNome){

            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;

            Console.WriteLine($"Seja Bem Vindo {primeiroNome}  {sobreNome}");
        }
    }
}