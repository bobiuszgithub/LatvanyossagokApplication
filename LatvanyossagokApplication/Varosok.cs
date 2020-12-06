using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Varosok
    {
        int id;
        string nev;
        int lakossag;
        List<Latvanyossagok> latvanyossagok;

        public Varosok(int id, string nev, int lakossag, List<Latvanyossagok> latvanyossagok)
        {
            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;
            this.latvanyossagok = latvanyossagok;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }
        internal List<Latvanyossagok> Latvanyossagok { get => latvanyossagok; set => latvanyossagok = value; }

        public override string ToString()
        {
            return string.Format("{0} - Lakosság: {1} fő", Nev, Lakossag);
        }
    }
}
