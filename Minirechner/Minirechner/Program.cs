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


            Console.Write(" Addition: ");
            Console.Write(Addiere(Zahl1, Zahl2));
            Console.WriteLine("");

            Console.Write(" Subtraktion: ");
            Console.Write(Subtrahiere(Zahl1, Zahl2));
            Console.WriteLine("");

            Console.Write(" Multiplikation: ");
            Console.Write(Multipliziere(Zahl1, Zahl2));
            Console.WriteLine("");


            Console.ReadKey();
        }

        static Int64 Addiere(Int64 zahl1, Int64 zahl2)
        {
            Int64 ErgebnisAddi = 0;

            ErgebnisAddi = zahl1 + zahl2;

            return ErgebnisAddi;
        }

        static Int64 Subtrahiere(Int64 zahl1, Int64 zahl2)
        {
            Int64 ErgebnisSubtr = 0;

            ErgebnisSubtr = zahl1 - zahl2;

            return ErgebnisSubtr;
        }

        static Int64 Multipliziere(Int64 zahl1, Int64 zahl2)
        {
            Int64 ErgebnisMulti = 0;

            ErgebnisMulti = zahl1 * zahl2;

            return ErgebnisMulti;
        }
    }
}
