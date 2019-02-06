using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mittelwert
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ende;

            string eingabe = string.Empty;

            int zaehler = 0;

            double zahl = 0;
            double summe = 0;
            double erg = 0;
           

            do
            {
                Console.Clear();
                zahl = 0;
                erg = 0;
                summe = 0;
                zaehler = 0;

                Console.WriteLine("\t\tMittelwert do-While Schleife Blasius");
                Console.WriteLine("\t\t------------------------------------\n\n");

                do
                {
                    

                    zahl = EingabeZahl("bitte Zahl eingeben: ");

                    if (zahl == 0)
                    {
                        ende = true;
                    }
                    else
                    {
                        ende = false;
                        summe = summe + zahl;
                        zaehler = zaehler + 1;
                    }
                } while (ende == false);

                erg = Berechnung(summe, zaehler);
                Ausgabe(erg);

                Console.Write("nochmal: ");
                Console.WriteLine("j für JA ");
                eingabe = Console.ReadLine();

            } while (eingabe == "j");

        }
        static double EingabeZahl(string text)
        {
            string eingabe = string.Empty;
            double zahl = 0;
            Console.Write(text);
            eingabe = Console.ReadLine();
            zahl = Convert.ToDouble(eingabe);
            return zahl;
        }

        static double Berechnung(double summe, int zaehler) 
        {
            double erg = 0;

        erg = summe / zaehler;

            return erg;

        }

        static void Ausgabe(double erg)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("das Ergebnis ist {0}", erg);
            Console.ReadLine();
        }

    

    }
}
