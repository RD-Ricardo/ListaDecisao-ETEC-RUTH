using System;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrTrabalhadas, vlHora, salarioBruto, impostoRenda, vlDescontoInss, salarioLiquido = 0;
            Console.Write("Digite o valor da hora trabalhada: ");
            vlHora = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite horas trabalhas: ");
            hrTrabalhadas = Convert.ToDouble(Console.ReadLine());
            salarioBruto = vlHora * hrTrabalhadas;
            // Verificando salario bruto para aplicar desconto do INSS
            if(salarioBruto <= 800.45)
               vlDescontoInss = salarioBruto - ((salarioBruto  * 7.65) / 100);
            else if(salarioBruto >= 800.46 && salarioBruto <= 900.00)
               vlDescontoInss = salarioBruto - ((salarioBruto  * 8.65) /  100);
            else if(salarioBruto >= 900.01 && salarioBruto <= 13334.07)
               vlDescontoInss = salarioBruto - ((salarioBruto  * 9) /  100);
            else if(salarioBruto >= 1334.08 && salarioBruto <= 2668.15)
               vlDescontoInss = salarioBruto - ((salarioBruto  * 11) /  100);
            else
                vlDescontoInss = salarioBruto - 293.50;

            // Verificando valor do salario com o desconto do INSS
            if(vlDescontoInss <= 1257.12)
                impostoRenda = 0;
            else if(vlDescontoInss >= 1257.13 && vlDescontoInss <= 2512.08)
                impostoRenda = ((vlDescontoInss * 15) / 100) - 188.57;
            else
                impostoRenda = ((vlDescontoInss * 27.5) / 100) - 502.58;
            
            // atribuindo o valor do salario liquido
            salarioLiquido = vlDescontoInss - impostoRenda;
            Console.WriteLine("SALARIO BRUTO: {0}",salarioBruto);
            Console.WriteLine("SALARIO LIQUIDO: {0}", salarioLiquido); 
        }
    }
}
