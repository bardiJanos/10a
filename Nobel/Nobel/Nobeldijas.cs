using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    public class Nobeldijas
    {
       

        public int Ev { get; set; }
        public string Tipus { get; set; }
        public string Keresztnev { get; set; }
        public string Vezeteknev { get; set; }

        public Nobeldijas(int ev, string tipus, string keresztnev, string vezeteknev)
        {
            Ev = ev;
            Tipus = tipus;
            Keresztnev = keresztnev;
            Vezeteknev = vezeteknev;
        }

    }
}
