using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log660_lab2
{
    public class Pays
    {
        public int idPays { get; set; }
        public string nomPays { get; set; }

        public Pays(int inIdPays, string inNomPays)
        {
            idPays = inIdPays;
            nomPays = inNomPays;
        }
    }
}
