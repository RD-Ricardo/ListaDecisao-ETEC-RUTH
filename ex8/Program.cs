using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            string nmFuncionario,departamento;
            Console.Write("Digite o nome do funcionário: ");
            nmFuncionario = Console.ReadLine();
            Console.Write("Digite o departamento do funcionário: ");
            departamento = Console.ReadLine().ToLower();
            Console.Write("Digite o sálario do funcionario: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if((salario >= 1000 && 
                salario <= 1500) && 
                (departamento == "e" || 
                departamento =="p"))
            {
                Console.WriteLine("");
                Console.WriteLine("Nome do funcionário {0}", nmFuncionario);
                Console.WriteLine("Sálario do funcioário {0}", salario);                
            }
            
        }
    }
}
