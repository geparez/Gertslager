using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gertslager.Models
{
    public class Hall
    {
        public int ID { get; set; }
        public bool Cooling { get; set; }
        public int Nummer { get; set; }

        public int Antal_rækker { get; set; }
        public string Beskrivelse { get; set; }

}
}
