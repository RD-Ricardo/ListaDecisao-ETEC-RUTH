using System;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double termometro;
            Console.Write("Digite o valor da Temperatura: ");
            termometro = Convert.ToDouble(Console.ReadLine());
            if(termometro < 100)
                Console.WriteLine("Temperatura está muito baixa.");
            else if(termometro >= 100 && termometro <= 200)
                Console.WriteLine("Temperatura está baixa.");
            else if(termometro > 200 && termometro < 500)
                Console.WriteLine("Temperatura está normal.");
            else 
                Console.WriteLine("Temperatura está muito alta.");
                
        }
    }
}
