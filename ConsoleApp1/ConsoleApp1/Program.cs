using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Escreva seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade: ");
            int idade  = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Escreva seu CEP: ");
            string CEP = Console.ReadLine();

            Console.WriteLine("Escreva seu endereco: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Escreva seu bairro: ");
            string bairro = Console.ReadLine();

            Console.WriteLine("Escreva seu completo: ");
            string complemento = Console.ReadLine();

            Console.WriteLine("Escreva seu numero: ");
            int numero = Convert.ToInt16(Console.ReadLine());




            Console.WriteLine(nome + " " + sobrenome);

            Console.WriteLine("Aperte o enter para finalizar...");
            Console.ReadLine();
            Console.WriteLine("Finalizou!");
        }
    }
}
