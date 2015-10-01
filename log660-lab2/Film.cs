using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log660_lab2
{
    public class Film
    {
        public int idFilm { get; set; }
        public string titreFilm { get; set; }
        public Pays paysFilm { get; set; }

        public Film(int inIdFilm, string inTitreFilm, Pays inPaysFilm)
        {
            idFilm = inIdFilm;
            titreFilm = inTitreFilm;
            paysFilm = inPaysFilm;
        }
    }
}
