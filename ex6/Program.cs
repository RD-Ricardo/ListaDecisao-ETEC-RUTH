using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double pProduto;
            Console.Write("Digite o valor do produto: ");
            pProduto = Convert.ToDouble(Console.ReadLine());
            if(pProduto >= 50 && pProduto <=100)
                Console.WriteLine("Produto em promoção.");
            else
                Console.WriteLine("Produto com preço normal.");
        }
    }
}
