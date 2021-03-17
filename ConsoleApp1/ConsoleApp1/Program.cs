using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Escreva seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Escreva seu CEP: ");
            string CEP = Console.ReadLine();

            Console.WriteLine("Escreva seu endereço: ");
            string endereço = Console.ReadLine();

            Console.WriteLine("Esccreva seu bairro: ");
            string bairro = Console.ReadLine();

            Console.WriteLine("Esccreva seu complemento: ");
            string complemento = Console.ReadLine();

            Console.WriteLine("Esccreva seu número: ");
            int numero = Convert.ToInt16(Console.ReadLine());





            Console.WriteLine(nome + " " + sobrenome);

            Console.WriteLine("Aperte o enter para finalizar... ");
            Console.ReadLine();

            Console.WriteLine("Finalizou!");


            //nome = nome + " " + sobrenome;
        }
    }
}
