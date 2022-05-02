using System;

namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            double pProduto;
            int cdOrigem;
            string procedencia = "";
            Console.Write("Digite preço do produto: ");
            pProduto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite código do produto: ");
            cdOrigem = Convert.ToInt16(Console.ReadLine());
            if(cdOrigem ==  1)
               procedencia = "Sul";
            else if(cdOrigem ==  2)
               procedencia = "Sudeste";
            else if(cdOrigem ==  3)
               procedencia = "Centro-Oeste";
            else if(cdOrigem ==  4)
               procedencia = "Norte";
            else if(cdOrigem ==  5)
               procedencia = "Nordeste";
            else
               procedencia = "CODIGO INVALIDO";  

            Console.WriteLine("Procedencia do Produto: {0}", procedencia);
            Console.WriteLine("Preço do Produto: {0}", pProduto);

        }
    }
}
