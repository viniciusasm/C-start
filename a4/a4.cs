using System;
namespace a3
{
    class Program
    {
        static int num = 0; // Campo da classe, acessível por todos os métodos da classe
        // O campo 'num' pode ser acessado por outros métodos da classe, como 'teste'.  
        static void Main(string[] args)
        {
            num = 10;
            teste();    // Chama o método teste, que tentará acessar 'num'
            Console.WriteLine("Valor de num no método Main: " + num);
            // O código acima compilará e executará corretamente, pois 'num' é um campo da classe.      
            Console.ReadLine(); // Espera o usuário pressionar Enter antes de fechar o console    
        }

        static void teste()
        {
            Console.WriteLine("Teste de método");
            Console.WriteLine(num);
            // O código acima não compilará porque 'num' é uma variável local do método Main
            // e não pode ser acessada diretamente por outros métodos.
            // Para corrigir isso, 'num' deve ser declarado como um campo da classe ou passado como parâmetro.
        }

    }
}