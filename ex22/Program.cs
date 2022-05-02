using System;

namespace ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            int cdProduto;
            Console.Write("Código do Produto: ");
            cdProduto = Convert.ToInt32(Console.ReadLine());
            if(cdProduto == 1)
               Console.WriteLine("Alimento não perecível");  
            else if(cdProduto == 2 || cdProduto ==  3 || cdProduto == 4)
               Console.WriteLine("Alimento perecível");
            else if(cdProduto == 5 || cdProduto == 6)
               Console.WriteLine("Vestuário");
            else if(cdProduto ==  7)
               Console.WriteLine("Higiene Pessoal");
            else if(cdProduto == 8 || cdProduto == 9)
               Console.WriteLine("Limpeza e Utensílios Domésticos");
            else
               Console.WriteLine("Inválido");  


        }
    }   
}
