using System;
using System.Security.Cryptography;
using System.Text;

namespace CriptografiaRSA
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider();
            Console.WriteLine("Bem-vindo ao Efac - Mensagens, uma empresa criada por Daniel e Bernardo!");
            Console.WriteLine();
   
            bool loop = true;

            while (loop)
            {
                Console.Write("Você deseja criptografar(1), descriptografar(2) ou sair(3) ?: ");
                int userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {

                    case 1:
                        Console.Write("Digite a mensagem que iremos criptografar: ");
                        string message = Console.ReadLine();
                        
                        Console.WriteLine("Mensagem:");
                        
                        byte[] encryptedMessage = Encrypt(message, rsaProvider);
                        Console.WriteLine(Convert.ToBase64String(encryptedMessage));
                        break;
                    case 2:
                        Console.Write("Digite a mensagem que irá ser descriptografada: ");
                        string encyptedMessageString = Console.ReadLine();
                        byte[] encryptedMessageBytes = Convert.FromBase64String(encyptedMessageString);
                        string decryptedMessage = Decrypt(encryptedMessageBytes, rsaProvider);

                        Console.WriteLine(decryptedMessage);
                        break;
                    case 3:
                        loop = false;
                        break;
                }
            }
            
        }

        static byte[] Encrypt(string data, RSACryptoServiceProvider rsa)
        {
            byte[] encodedMessage = Encoding.UTF8.GetBytes(data);
            byte[] encryptedMessage = rsa.Encrypt(encodedMessage, true);  
            
            return encryptedMessage;
        }

        static string Decrypt(byte[] data, RSACryptoServiceProvider rsa)
        {
            byte[] decryptedMessage = rsa.Decrypt(data, true);
            string originalMessage = Encoding.UTF8.GetString(decryptedMessage);

            return originalMessage;
        }
    }
}