using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
   public class StanjeEnum :BaseEnum
    {
        public static StanjeEnum Stop = new StanjeEnum(0,"Stop");
        public static StanjeEnum Paly = new StanjeEnum(1, "Play");
        public static StanjeEnum Pause = new StanjeEnum(2, "Pause");
        public static StanjeEnum Next = new StanjeEnum(3, "Next");
        public static StanjeEnum Previous = new StanjeEnum(4, "Previous");



        public StanjeEnum(int id, string value) : base(id, value)
        {
        }
    }

    public class BaseEnum
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public BaseEnum(int id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
