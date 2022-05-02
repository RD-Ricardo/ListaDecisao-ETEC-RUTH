using System;

namespace ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            int pag, he,me,hs,ms, h, m;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("- Calcular Valor estacionamento -");
            Console.WriteLine("---------------------------------");
            Console.Write("Digite a hora de ENTRADA: ");
            he = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o minuto de ENTRADA: ");
            me = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite a hora de SAIDA: ");
            hs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o minuto de SAIDA: ");
            ms = Convert.ToInt32(Console.ReadLine());
            if(hs < he)
                hs = hs+24;
            if(ms < me){
                ms = ms+60;
                hs = hs - 1;
            }
            h  = hs - he;
            m  = ms - me;
            pag = h * 60 + m;

            if((pag > 60))
                Console.WriteLine("Valor a pagar {0} reais", pag = 4);        
        }
    }
}
