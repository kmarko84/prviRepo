using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
   public class MuzickaLinija
    {
        private int ukupanBrojPjesama;

        public int UkupanBrojPjesama
        {

            get { return  ukupanBrojPjesama; }
            set { ukupanBrojPjesama = value; }
         }

        private int BrPjesama
        {

            set
            {
                if (value > 0 && value<ukupanBrojPjesama)
                {
                    BrPjesama = value;
                }
            }
        }

        private int stanje;

        public int Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }

        private string[] pjesme;

        public int TrenutnoStanjeMuzickeLinije
        {
            get { return stanje; }
        }

        public string[] Pjesme
        {
            get { return pjesme; }
            set
            {
                if (value.Length<=100)
                {
                    pjesme = value;

                }
            }
        }

        public MuzickaLinija(string[] nizPjesmi)
        {
            BrPjesama = 0;
            Stanje = StanjeEnum.Paly.Id;
           
        }

        public MuzickaLinija(string[] nizPjesmi, int pocetnaPjesma, int pocetnoStanje)
        {
            Pjesme = nizPjesmi;
            BrPjesama = pocetnaPjesma;
            Stanje = pocetnoStanje;
        }


        public MuzickaLinija(string[] nizPjesmi, int pocetnaPjesma, StanjeEnum pocetnoStanje)
        {
            Pjesme = nizPjesmi;
            BrPjesama = pocetnaPjesma;
            Stanje = pocetnoStanje.Id;
        }


    }
}
