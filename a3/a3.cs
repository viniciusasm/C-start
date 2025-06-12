using System;
namespace a3
{
    class Program
    {
        static void Main()
        {

            byte n1 = 10; // entre 0 e 255
            int num = 0; // entre -2.147.483.648 e 2.147.483.647
            long n2 = 10000000000; // entre -9.223.372.036.854.775.808 e 9.223.372.036.854.775.807  
            char letra = 'a'; // entre 0 e 65535 (Unicode)
            bool ativo = true; // ou false  
            float valor = 3.14f; // entre -3.402823E+38 e 3.402823E+38
            double valor2 = 3.14; // entre -1.79769313486232E+308 e 1.79769313486232E+308       
            string texto = "Olá mundo ...";
            var aux = 10; // tipo implícito, pode ser int, long, float, etc. dependendo do valor atribuído
            Console.WriteLine("Tipos de dados em C#:");
            Console.WriteLine("n1 (byte): " + n1);
            Console.WriteLine("num (int): " + num);
            Console.WriteLine("n2 (long): " + n2);
            Console.WriteLine("letra (char): " + letra);
            Console.WriteLine("ativo (bool): " + ativo);
            Console.WriteLine("valor (float): " + valor);
            Console.WriteLine("valor2 (double): " + valor2);
            Console.WriteLine("texto (string): " + texto);
            Console.WriteLine("aux: " + aux);
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey(); // espera o usuário pressionar uma tecla antes de fechar o console
        }

    }
}