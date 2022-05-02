using System;

namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if(idade >= 5 && idade <= 7)
               Console.WriteLine("Categoria: Infantil A");
            else if(idade >= 8 && idade <= 10)
               Console.WriteLine("Categoria: Infantil B");
            else if(idade >= 11 && idade <= 13)
               Console.WriteLine("Categoria: Juvenil A");
            else if(idade >= 14 && idade <= 17)
               Console.WriteLine("Categoria: Juvenil B");
            else if(idade > 18)
               Console.WriteLine("Categoria: Adulto");
               
        }
    }
}
