using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo;
            Console.Write("Digite o código do livro: ");
            codigo = Console.ReadLine().ToLower();
            if(codigo ==  "a")
                Console.WriteLine("\nCategoria do livro: Ficção.");
            else if(codigo == "b")
                Console.WriteLine("\nCategoria do livro: Não-Ficção."); 
            else
                Console.WriteLine("\nCodigo Inválido.");   
        }
    }
}
