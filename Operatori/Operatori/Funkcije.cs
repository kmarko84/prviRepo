using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Funkcije
    {
        public static void IspisPoglavlje(string poglavlje)
        {
            Console.Clear();
            Console.WriteLine("\n##########################################");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t" + poglavlje);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n##########################################");
        }

        public static void Ispis(string nestoZaIspis)
        {
            Console.Write(nestoZaIspis);
        }

        public static int UnosInt(string nestoZaIspis)
        {
            Ispis(nestoZaIspis + " > ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string UnosTekst(string nestoZaIspis)
        {
            Ispis(nestoZaIspis + " > ");
            return Console.ReadLine();
        }

        public static float UnosDecimal(string nestoZaIspis)
        {
            Ispis(nestoZaIspis + " > ");
            return (float)Convert.ToDouble(Console.ReadLine());
        }

        public static DateTime UnosDatum(string nestoZaIspis)
        {
            Ispis(nestoZaIspis + " > ");
            return Convert.ToDateTime(Console.ReadLine());
        }

        public static char UnosZnak(string nestoZaIspis)
        {
            Ispis(nestoZaIspis + " > ");
            return Convert.ToChar(Console.ReadKey());
        }

        public static bool UnosBool(string nestoZaIspis)
        {
            Ispis(nestoZaIspis + " > ");
            return Convert.ToBoolean(Console.ReadKey());
        }

        public static void Stop()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}