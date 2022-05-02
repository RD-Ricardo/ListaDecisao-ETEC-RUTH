using System;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            double pEtiqueta, cProduto, valor;
            Console.Write("Digite o preço da etiqueta: ");
            pEtiqueta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o codigo do produto: ");
            cProduto =Convert.ToDouble(Console.ReadLine());
            if(cProduto == 1)
            {
                valor = pEtiqueta - ((pEtiqueta * 10) / 100);
                Console.WriteLine("À vista em dinheiro ou cheque, com 10% de desconto");
                Console.WriteLine("Valor do produto com desconto: " + valor);
            }
            else if(cProduto == 2)
            {
                valor = pEtiqueta - ((pEtiqueta * 5) / 100);
                Console.WriteLine("À vista com cartão de crédito, com 5% de desconto");
                Console.WriteLine("Valor do produto com desconto: " + valor);
            }
            else if(cProduto == 3)
            {
                Console.WriteLine("Em 2 vezes, preço normal de etiqueta sem juros");
            }
            else if(cProduto == 4)
            {
                valor = pEtiqueta + ((pEtiqueta * 10) / 100);
                Console.WriteLine("Em 3 vezes, preço de etiqueta com acréscimo de 10%");
                Console.WriteLine("Valor do produto com desconto: " + valor);
            }
        }
    }
}
