using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioNovo = 0, salario;
            Console.Write("Digite o salario do funcionário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if(salario < 500)
                salarioNovo = ((salario * 15)/  100) + salario;
            else if(salario >= 500 && salario <= 1000)
                salarioNovo = ((salario * 10)/ 100)+ salario;
            else
                salarioNovo = ((salario *5) / 100) + salario;

            Console.WriteLine("Reajuste de salario: {0}", salarioNovo);
        }
    }
}
