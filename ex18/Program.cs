using System;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual  = 2022, anoNascimento, idade;
            Console.Write("Digite seu ano de nascimento: ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());
            idade =  anoAtual - anoNascimento;
            if(idade>= 16)
                Console.WriteLine("Já tem idade para votar.");
            if(idade >= 18)
                Console.WriteLine("Já pode conseguir a sua carteira de habilitação.");

            Console.WriteLine("Sua idade é {0}.", idade);
        }
    }
}
