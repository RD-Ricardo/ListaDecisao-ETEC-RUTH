using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            double caixa,qtd,pr, totalPrazo, totalAvista;
            Console.Write("Digite a quantidade de dinheiro no caixa: ");
            caixa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade de Produtos a comprar: ");
            qtd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Preço da unidade produto: ");
            pr = Convert.ToDouble(Console.ReadLine());
            if((qtd * pr) > (caixa * 80 / 100)){
                totalPrazo = ((qtd * pr) + ((qtd * pr) * 10) / 100);
                Console.WriteLine("\nForma de Pagamento escolhida: A PRAZO");
                Console.WriteLine("Total a prazo: {0}", totalPrazo);
            }
            else{
                totalAvista = ((qtd * pr) - ((qtd * pr) * 5) / 100);
                Console.WriteLine("\nForma de Pagamento escolhida: A VISTA");
                Console.WriteLine("Total a vista: {0}", totalAvista);
            }

        }
    }
}
