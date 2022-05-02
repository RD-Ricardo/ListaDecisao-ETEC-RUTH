using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlGasto, cpTanque;
            string tpCarro;
            Console.Write("Digite a capacidade do tanque do carro: ");
            cpTanque = Convert.ToDouble(Console.ReadLine());
            Console.Write("Selecione o tipo do carro álcool(A) gasolina(G): ");
            tpCarro = Console.ReadLine().ToLower();
            if(tpCarro == "g")
                vlGasto = cpTanque * 1.80;
            else 
                vlGasto = cpTanque * 1.00;

            Console.WriteLine("O valor gasto é {0}", vlGasto);    
        }
    }
}
