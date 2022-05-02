using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlMes;
            string nmVendedor;
            Console.Write("Digite o nome do vendedor: ");
            nmVendedor = Console.ReadLine();
            Console.Write("Digite o valor das vendas do mês: ");
            vlMes = Convert.ToDouble(Console.ReadLine());
            if(vlMes >= 10000 && vlMes <= 50000)
                Console.WriteLine("Nome do vendedor: {0}", nmVendedor);
        }
    }
}
