using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
   public static class MuzickaLinijaExt
    {
        public static string[] NizPjesama(this MuzickaLinija muzickaLinija)
        {
            return muzickaLinija.Pjesme;
        }


        public static object NizPjesama(this MuzickaLinija muzickaLinija, string nazivPjesme)
        {
            var pjesma = from pjesme in muzickaLinija.Pjesme where pjesme == nazivPjesme select new { NazivNovePjesme = pjesme };

            return pjesma.ToList()[0].NazivNovePjesme;
        }
    }
}
