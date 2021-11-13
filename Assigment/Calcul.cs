using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment
{
    class Calcul
    {
        public List<string> flecheAssociee(double longueur, double charge, double quadra, double young)
        {
            List<string> flecheA = new List<string>();

            //Ajout du résultat du calcul de la flèche associée
            flecheA.Add(((charge * longueur * longueur * longueur) / (3 * young * quadra)).ToString());

            //Ajout du détail du calcul de la flèche associée
            flecheA.Add("(" + charge + "*" + longueur + "^3)/(3*" + young + "*" + quadra + ")");

            return flecheA;
        }

        public List<string> flecheMax(double longueur, double section, double charge, double quadra, double young)
        {
            List<string> flecheM = new List<string>();

            //Ajout du résultat du calcul de la flèche maximale
            flecheM.Add(((section * longueur * longueur * longueur) / (3 * quadra)).ToString());

            //Ajout du détail du calcul de la flèche maximale
            flecheM.Add("(" + section + "*" + longueur + "^3)/(3*" + quadra + ")");

            return flecheM;
        }

        public bool valide(double flecheA, double flecheM)
        {
            //Vérification de la flèche associé en fonction de la flèche maximale
            if (flecheA < flecheM)
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }

    }
}
