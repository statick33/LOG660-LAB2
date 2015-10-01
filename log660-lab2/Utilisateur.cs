using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log660_lab2
{
    class Utilisateur : Personne
    {
        public Utilisateur(int inIdPersonne, string inUsernameUtilisateur, string inPasswordUtilisateur)
        {
            idPersonne = inIdPersonne;
            usernameUtilisateur = inUsernameUtilisateur;
            passwordUtilisateur = inPasswordUtilisateur;
        }

        public string usernameUtilisateur { get; set; }
        public string passwordUtilisateur { get; set; }
    }
}
