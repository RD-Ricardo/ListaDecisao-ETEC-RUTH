using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Console.Write("Digite um número interio: ");
            x = Convert.ToInt32(Console.ReadLine());
            if(x < 0)
                y = x * -1;
            else
                y = x;

            Console.WriteLine("o modulo desse número é {0}", y);    
        }
    }
}
