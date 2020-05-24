using System;

namespace fgts
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Calcular a parcela do FGTS sobre o salário de um funcionário 8%.");
            Console.WriteLine("Sálario: R$ 2000,00");
            double resultado=2000 * 8;
            double resultado2=resultado / 100;
            
            Console.WriteLine($"FGTS: R$ {resultado2},00");
        }
    }
}
