using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assigment
{
    class EcritureLog
    {
        Calcul calcul = new Calcul();

        public string CreationLog()
        {
            //Création du nom du fichier
            string filename = "calcul_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("HH-mm-ss") + ".txt";
            
            try
            {
                //Création du fichier
                File.Create(filename).Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return filename;
        }

        public void Ecriture(double longueur, string forme, double section, double charge, double quadra, double young, string fichier)
        {
            string filename = fichier;

            //Calcul de la flèche associée
            List<string> resultatCalculAssocie = calcul.flecheAssociee(longueur, charge, quadra, young);

            //Calcul de la flèche maximale
            List<string> resultatCalculMax = calcul.flecheMax(longueur, section, charge, quadra, young);

            //Création du texte à écrire dans le fichier
            string ligne = DateTime.Now.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("HH-mm-ss") + " : \n" +
                "Longueur : " + longueur + "\n" +
                "Forme : " + forme + "\n" +
                "Section : " + section + "\n" +
                "Charge : " + charge + "\n" +
                "Moment quadratique : " + quadra + "\n" +
                "Module d'Young : " + young + "\n" +
                "Flèche associés : " + resultatCalculAssocie[1] + " = " + resultatCalculAssocie[0] + "\n" +
                "Flèche max : " + resultatCalculMax[1] + " = " + resultatCalculMax[0] + "\n";

            //Vérification de la validité de la flèche et ajout du résultat au texte
            if (calcul.valide(double.Parse(resultatCalculAssocie[0]), double.Parse(resultatCalculMax[0])) == true)
            {
                ligne += "La charge peut être supportée par la poutre encastrée !!!\n\n";
            }
            else
            {
                ligne += "La charge ne peut pas être supportée par la poutre encastrée.\n\n";
            }

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
                {
                    //Ecriture du text dans le fichier
                    file.WriteLine(ligne);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
