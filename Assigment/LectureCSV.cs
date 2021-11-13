using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assigment
{
    class LectureCSV
    {
        private Dictionary<string, double> infosPoutre;

        public LectureCSV()
        {
            infosPoutre = new Dictionary<string, double>();
        }

        public Dictionary<string, double> ImportInfosPoutreFromFile(string filename)
        {
            try
            {
                var reader = new StreamReader(File.OpenRead(filename));
                while (!reader.EndOfStream)
                {
                    //Lecture ligne par ligne
                    var line = reader.ReadLine();

                    //Séparation d'une ligne en deux
                    var values = line.Split(':');

                    //Ajout des informations des matériaux
                    infosPoutre.Add(values[0], Double.Parse(values[1]));
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return infosPoutre;
        }

        
        public bool testChiffre(string texte)
        {
            bool resultat = false;

            if (texte.All(char.IsDigit))
            {
                resultat = true;
            }

            return resultat;
        }
    }
}
