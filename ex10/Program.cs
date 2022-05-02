using System;
using System.ComponentModel.DataAnnotations;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,valor;
            Console.Write("Digite o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            if(a == b){ 
                valor  = a + b;
                Console.WriteLine("Soma dos Dois números: {0}", valor);
            }
            else if(a > b || b > a){    
                valor = a - b;
                if(valor < 0){
                    valor = valor * -1;
                    Console.WriteLine("Diferença dos Dois números é {0}", valor);
                }
                else{
                    Console.WriteLine("Diferença dos Dois números é {0}", valor);
                }
            }
               
        }
    }
}
