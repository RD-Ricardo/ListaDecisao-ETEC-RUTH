﻿using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlConta;
            Console.Write("Digite o valor da conta de luz: ");
            vlConta = Convert.ToDouble(Console.ReadLine());
            if(vlConta >  50)
                Console.WriteLine("Você está gastando muito.");
        }
    }
}
