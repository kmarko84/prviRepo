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

        private int brPjesme;

        public int BrPjesama
        {
            get
            {
                return brPjesme;
            }

            set
            {
                if (value > 0 && value<ukupanBrojPjesama)
                {
                    brPjesme = value;
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
            UkupanBrojPjesama = nizPjesmi.Length;
            BrPjesama = 0;
            Stanje = StanjeEnum.Paly.Id;


        }

        public MuzickaLinija(string[] nizPjesmi, int pocetnaPjesma, int pocetnoStanje)
        {
            Pjesme = nizPjesmi;
            UkupanBrojPjesama = nizPjesmi.Length;
            BrPjesama = pocetnaPjesma;
            Stanje = pocetnoStanje;
        }


        public MuzickaLinija(string[] nizPjesmi, int pocetnaPjesma, StanjeEnum pocetnoStanje)
        {
            Pjesme = nizPjesmi;
            UkupanBrojPjesama = nizPjesmi.Length;
            BrPjesama = pocetnaPjesma;
            Stanje = pocetnoStanje.Id;

        }

        public string Display()
        {
            string ispis = "";
            if (Stanje == 0)
            {
                ispis = "Stop ";
            }
            else if(Stanje == 1)
            {
                ispis = "Play ";

            }
            else if (Stanje == 2)
            {
                ispis = "Pause ";

            }
            else if (Stanje == 3)
            {
                ispis = "Next ";

            }
            else if (Stanje == 4)
            {
                ispis = "Previous ";
            }

            //ispis += this.brPjesme + " . " + Pjesme[this.brPjesme];
            ispis += string.Format("{0}.{1}", this.brPjesme + 1, Pjesme[this.brPjesme]);
            return ispis;
        }

        public void Stop()
        {
            Stanje = StanjeEnum.Stop.Id;
            BrPjesama = 0;
        }
        

        //indexer
        public string this[int index]
        {
            get
            {
                return Pjesme[index];
            }
        }

        public static MuzickaLinija operator ++(MuzickaLinija mz)
        {
            mz.brPjesme += 2;
            return mz;

        }

        public static MuzickaLinija operator --(MuzickaLinija mz)
        {
            mz.brPjesme -= 2;
            return mz;

        }

        public static bool operator > (MuzickaLinija linija1,MuzickaLinija linija2)
        {
            if (linija1.UkupanBrojPjesama > linija2.UkupanBrojPjesama)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(MuzickaLinija linija1, MuzickaLinija linija2)
        {
            if (linija1.UkupanBrojPjesama < linija2.UkupanBrojPjesama)
            {
                return true;
            }
            return false;
        }

        



    }
}
