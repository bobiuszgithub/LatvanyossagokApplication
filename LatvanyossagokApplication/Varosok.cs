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

        public Varosok(int id, string nev, int lakossag)
        {
            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }


        public override string ToString()
        {
            return string.Format("{0} - Lakosság: {1} fő", nev, lakossag);
        }
    }
}
