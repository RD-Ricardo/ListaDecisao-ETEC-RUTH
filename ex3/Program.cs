using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoIdeal;
            string sexo;
            Console.Write("Digite seu sexo homem(H) mulher(M): ");
            sexo = Console.ReadLine().ToLower();
            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            if(sexo == "h")
                pesoIdeal = (72.7 * altura) - 58;
            else
                pesoIdeal = (62.1 * altura) - 44.7;    
            
            Console.WriteLine("Seu peso ideal é {0} kg", pesoIdeal / 100);
            
        }
    }
}
