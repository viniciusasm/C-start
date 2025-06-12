using System;
namespace a5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula de operações e operadores em C# 
            // Operadores aritméticos, lógicos e relacionais    
            int res = 10 + 5; // Soma de dois números inteiros
            bool resultado = res < 10; // Variável booleana
            Console.WriteLine("Resultado da soma: " + res); // Exibe o resultado da soma
            Console.WriteLine("Resultado da comparação: " + resultado); // Exibe o resultado da comparação
            res += 5; // Incrementa o valor de res em 5
            Console.WriteLine("Resultado após incremento: " + res); // Exibe o resultado após o incremento  
            res -= 3; // Decrementa o valor de res em 3
            Console.WriteLine("Resultado após decremento: " + res); // Exibe o resultado após o decremento  
            res *= 2; // Multiplica o valor de res por 2
            Console.WriteLine("Resultado após multiplicação: " + res); // Exibe o resultado após a multiplicação    
            res /= 4; // Divide o valor de res por 4
            Console.WriteLine("Resultado após divisão: " + res); // Exibe o resultado após a divisão    
            res %= 3; // Calcula o resto da divisão de res por 3
            Console.WriteLine("Resultado após módulo: " + res); // Exibe o resultado após o cálculo do módulo
            // Operadores lógicos
            resultado = (res > 0) && (res < 10); // Operador lógico AND
            Console.WriteLine("Resultado do operador lógico AND: " + resultado); // Exibe o resultado do operador lógico AND
            resultado = (res < 0) || (res > 10); // Operador lógico OR
            Console.WriteLine("Resultado do operador lógico OR: " + resultado); // Exibe o resultado do operador lógico OR  
            resultado = !(res == 0); // Operador lógico NOT
            Console.WriteLine("Resultado do operador lógico NOT: " + resultado); // Exibe o resultado do operador lógico NOT    
            // Operadores relacionais
            bool comparacao = (res == 0); // Igualdade
            Console.WriteLine("Resultado da comparação de igualdade: " + comparacao); // Exibe o resultado da comparação de igualdade       
            comparacao = (res != 0); // Desigualdade
            Console.WriteLine("Resultado da comparação de desigualdade: " + comparacao); // Exibe o resultado da comparação de desigualdade 
            comparacao = (res < 5); // Menor que
            Console.WriteLine("Resultado da comparação menor que: " + comparacao); // Exibe o resultado da comparação menor que 
            Console.WriteLine("Pressione qualquer tecla para sair..."); // Mensagem para o usuário
            Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o console
        }
    }
}   