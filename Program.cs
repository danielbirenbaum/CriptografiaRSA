using System;
using System.Security.Cryptography;

namespace CriptografiaRSA
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo ao Efac - Mensagens, uma empresa criada por Daniel e Bernardo!");
            Console.WriteLine();
            Console.Write("Você deseja criptografar(1) ou descriptografar(2) uma mensagem?: ");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Digite a mensagem que iremos criptografar: ");
                    string message = Console.ReadLine();

                    break;
                case 2:
                    break;
            }  
        }
    }
}