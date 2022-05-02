using System;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrTrabalhadas, vlHora, salarioBruto, impostoRenda, vlDescontoInss, salarioLiquido = 0;
            Console.Write("Digite o valor da hora trabalhada: ");
            vlHora = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite horas trabalhadas: ");
            hrTrabalhadas = Convert.ToDouble(Console.ReadLine());
            salarioBruto = vlHora * hrTrabalhadas;
            vlDescontoInss = salarioBruto - (salarioBruto  * 0.11);
            if(vlDescontoInss <= 1257.12)
                impostoRenda = 0;
            else if(vlDescontoInss >= 1257.13 && vlDescontoInss <= 2512.08)
                impostoRenda = ((vlDescontoInss * 15) / 100) - 188.57;
            else
                impostoRenda = ((vlDescontoInss * 27.5) / 100) - 502.58;
            
            salarioLiquido = vlDescontoInss - impostoRenda;
            Console.WriteLine("Salário Bruto: " + salarioBruto);
            Console.WriteLine("Salário Líquido: " + salarioLiquido);

        }
    }
}
