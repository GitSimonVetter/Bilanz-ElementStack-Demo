using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabeName;
            double eingabeUmsatz;
            string eingabe;
            List<string> vertreterName = new List<string>();
            List<double> vertreterUmsatz = new List<double>();
            while (true)
            {
                Console.WriteLine("Name?");
                eingabeName = Console.ReadLine();
                vertreterName.Add(eingabeName);
                Console.WriteLine("Umsatz?");
                eingabeUmsatz = Convert.ToDouble(Console.ReadLine());
                vertreterUmsatz.Add(eingabeUmsatz);

                Console.WriteLine(eingabeName + " " + Convert.ToString(eingabeUmsatz));
                Console.WriteLine("Weitere Hinzufügen?  yes/no");
                eingabe = Console.ReadLine();
                if (eingabe == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Bilanz");
                    Console.WriteLine();

                    break;
                }

            }


            for (int i= 0; i < vertreterName.Count; i++)
            {
                    Console.Write("Name:");
                    Console.WriteLine(vertreterName[i]);
                    Console.Write("Umsatz:");
                    Console.WriteLine(vertreterUmsatz[i]);
                    Console.WriteLine("\n");

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadKey();
        }
    }
}
