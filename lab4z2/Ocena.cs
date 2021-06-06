using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4z2
{
    public class Ocena
    {
        public string kurs { set; get; }
        public int ocena { set; get; }

        public Ocena(string kurs, int ocena)
        {
            this.kurs = kurs;
            this.ocena = ocena;
        }

        public Ocena()
            : this("", 2)
        { }
    }
}
