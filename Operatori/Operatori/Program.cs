using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojPjersama = Funkcije.UnosInt("Koliko pjesama se nalazi na CD-u?");
            string[] nizPjesme = new string[brojPjersama];
            for (int i = 0; i < brojPjersama; i++)
            {
                nizPjesme[i] = Funkcije.UnosTekst("Unesite podatke o " + (i+1) + ". pjesmi");
            }

            int pocetnoStanje = Funkcije.UnosInt("Pocetno stanje muzicke linije (0-stop, 1-play)");

            if (pocetnoStanje ==1)
            {
                int brojPjesme = Funkcije.UnosInt("Prva pjesma (broj pjesme od koje zelite da list krene)?");
                MuzickaLinija muzickaLinija = new MuzickaLinija(nizPjesme,brojPjesme+1,pocetnoStanje);

                muzickaLinija++;
                muzickaLinija++;

                muzickaLinija--;
                Funkcije.Ispis(muzickaLinija.Display());

                MuzickaLinija linija2 = new MuzickaLinija(muzickaLinija.Pjesme,muzickaLinija.BrPjesama,muzickaLinija.Stanje);
                linija2.UkupanBrojPjesama -= 2;

                if (muzickaLinija > linija2)
                {
                    Funkcije.Ispis("Linija 2 ima vise pjesama");
                }

                linija2.NizPjesama();
                linija2.NizPjesama("Opila me tvoja ljepota");
            }

          

            
            Funkcije.Stop();


        }
    }
}
