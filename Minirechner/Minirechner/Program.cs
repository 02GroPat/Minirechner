using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Gross Patrick
//4BEL
//Minirechner, welcher die Grundrechenarten von zwei eingegebenen Integer Zahlern durchführt
namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 Zahl1;
            Int64 Zahl2;

            Console.WriteLine("");
            Console.Write(" Minirechner: \n");
            Console.WriteLine();

            Console.Write(" Bitte die erste Zahl eingeben: ");
            Zahl1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("");

            Console.Write(" Bitte die zweite Zahl eingeben: ");
            Zahl2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" Ergebnisse:");
            Console.WriteLine("");
        }
    }
}
