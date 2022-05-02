using System;
using System.Reflection.Metadata;

namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            Console.Write("Comprimento do lado A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Comprimento do lado B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Comprimento do lado C: ");
            c = Convert.ToDouble(Console.ReadLine());
            if(a == b && a == c)
                Console.WriteLine("Triângulo Equilátero");
            else if(a == b || a == c || b == c)
                Console.WriteLine("Triângulo isósceles");
            else
                Console.WriteLine("Triângulo escaleno");
            
        }
    }
}
