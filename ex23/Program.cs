using System;

namespace ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            double dsCruzamento; 
            string corSemaforo;
            Console.WriteLine("Cores Semaforos   --");
            Console.WriteLine("(V) = Vermelho.   --");
            Console.WriteLine("(A) = Amarelo.    --");
            Console.WriteLine("(D) = Verde.      --");
            Console.Write("Digite cor do semaforo: ");
            corSemaforo = Console.ReadLine().ToLower();
            if(corSemaforo == "v"){
                Console.WriteLine("Parar !!");
                return;
            }
            
            else{
                if(corSemaforo ==  "d"){
                    Console.WriteLine("Passar !!");
                    return;
                }
                else{
                    Console.Write("Digite a distância  cruzamento: ");
                    dsCruzamento = Convert.ToDouble(Console.ReadLine());
                    if(corSemaforo == "a" && dsCruzamento < 5)
                        Console.WriteLine("Passar com cuidado !!");
                    else if(corSemaforo == "a" && dsCruzamento >= 5)
                        Console.WriteLine("Parar !!");
                }
            }
            
        }
    }
}
