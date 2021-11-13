using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assigment
{
    public partial class Form1 : Form
    {
        Calcul calcul;
        LectureCSV lecture;
        EcritureLog ecriture;

        string filename = "moduleYoung.abaque";

        double longueur;
        string forme;
        double charge;
        double quadra;
        double young;
        double section;

        Dictionary<string, double> abaque = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();
            calcul = new Calcul();
            lecture = new LectureCSV();
            ecriture = new EcritureLog();
            
            //Remplissage des matériaux par défaut
            abaque = lecture.ImportInfosPoutreFromFile(filename);
            foreach (KeyValuePair<string, double> materiaux in abaque)
            {
                comboBoxMateriaux.Items.Add(materiaux.Key);
            }

            //Réglage de l'affichage
            flecheAssociee.ForeColor = System.Drawing.Color.White;

            trackBarCharge.BringToFront();
            trackBarQuadra.BringToFront();
            buttonAbaque.BringToFront();

            flecheAssociee.Text = "";
            flecheMax.Text = "";
            labelValidite.Text = "";
        }

        private void buttonCalcul_Click(object sender, EventArgs e)
        {
            //Vérification que tous les champs soient remplis
            if ((textBoxLongueur.Text == "") || (comboBoxForme.Text == "") || (textBoxCharge.Text == "") || (textBoxQuadra.Text == "") || (textBoxYoung.Text == ""))
            {
                MessageBox.Show("Veuillez compléter tous les champs svp.");
            } else
            {
                //Stockage des valeurs rentrées par l'utilisateur
                longueur = Double.Parse(textBoxLongueur.Text);
                forme = comboBoxForme.Text;
                charge = Double.Parse(textBoxCharge.Text);
                quadra = Double.Parse(textBoxQuadra.Text);
                young = Double.Parse(textBoxYoung.Text);
                section = Double.Parse(textBoxSection.Text);

                //Calcul des flèches
                flecheAssociee.Text = calcul.flecheAssociee(longueur, charge, quadra, young)[0];
                flecheMax.Text = calcul.flecheMax(longueur, section, charge, quadra, young)[0];

                //Réglage de l'affichage
                flecheAssociee.BackColor = System.Drawing.Color.Purple;
                flecheMax.BackColor = System.Drawing.Color.Yellow;

                //Vérification de l'endroit où l'on stock les calculs
                //Si aucun endroit n'a été sélectionné, on crée un fichier
                if (openFileDialog2.FileName == "openFileDialog2")
                {
                    filename = ecriture.CreationLog();
                    openFileDialog2.FileName = "";
                }
                //Ecriture des calculs dans le fichier
                ecriture.Ecriture(longueur, forme, section, charge, quadra, young, filename);

                //Vérification de la flèche associée et max et réglage de l'affichage
                if (calcul.valide(double.Parse(flecheAssociee.Text), double.Parse(flecheMax.Text)) == true)
                {
                    labelValidite.Text = "La charge peut être supportée par la poutre encastrée !!!";
                    labelValidite.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    labelValidite.Text = "La charge ne peut pas être supportée par la poutre encastrée";
                    labelValidite.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void buttonSauvegarde_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void buttonAbaque_Click(object sender, EventArgs e)
        {
            //Nettoyage de l'affichage
            comboBoxMateriaux.Items.Clear();
            abaque.Clear();
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //Récupération des informations sur les matériaux
            filename = openFileDialog1.FileName;
            abaque = lecture.ImportInfosPoutreFromFile(filename);

            //Remplissage des matériaux
            foreach (KeyValuePair<string, double> materiaux in abaque)
            {
                comboBoxMateriaux.Items.Add(materiaux.Key);
            }
            comboBoxMateriaux.Text = "Séléctionner un matériau";
            textBoxYoung.Text = "";
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            //Récupération du nouveau chemin
            filename = openFileDialog2.FileName;
        }

        private void comboBoxMateriaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affichage du module d'Young
            textBoxYoung.Text = abaque[comboBoxMateriaux.Text].ToString();
        }

        private void comboBoxForme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fullPath;
            try
            {
                if (comboBoxForme.Text == "Rectangulaire")
                {
                    //Récuperation du chemin
                    string fileName = "Photo\\Rectangulaire.png";
                    fullPath = Path.GetFullPath(fileName);

                    //Affichage de l'image d'une poutre rectangulaire
                    pictureBox1.Image = Image.FromFile(fullPath);
                }
                if (comboBoxForme.Text == "Circulaire")
                {
                    //Récuperation du chemin
                    string fileName = "Photo\\Circulaire.png";
                    fullPath = Path.GetFullPath(fileName);

                    //Affichage de l'image d'une poutre circulaire                 
                    pictureBox1.Image = Image.FromFile(fullPath);
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
            }
        }

        //Lien et affichage entre les trackBar et les textBox
        private void trackBarLongueur_ValueChanged(object sender, EventArgs e)
        {
            textBoxLongueur.Text = trackBarLongueur.Value.ToString();
            longueur = trackBarLongueur.Value;
        }

        private void textBoxYoung_TextChanged(object sender, EventArgs e)
        {
            if (textBoxYoung.Text == "")
            {
                comboBoxMateriaux.Text = "Séléctionner un matériau";
            }
            else if (textBoxYoung.Text.All(char.IsDigit))         //Vérification que des chiffres sont rentrés
            {
                if (abaque.ContainsValue(Double.Parse(textBoxYoung.Text)))     //Voir si 2 matériaux ont le même module
                {
                    comboBoxMateriaux.Text = abaque.FirstOrDefault(x => x.Value == Double.Parse(textBoxYoung.Text)).Key; ;
                }
                else
                {
                    comboBoxMateriaux.Text = "Inconnu";
                }
            }
            else
            {
                MessageBox.Show("Veuillez rentrer des chiffres et non des lettres.");
                textBoxYoung.Text = "";
            }
            
        }

        private void textBoxLongueur_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLongueur.Text == "")
            {
                trackBarLongueur.Value = 0;
            } else
            {
                if (textBoxLongueur.Text.All(char.IsDigit))         //Vérification que des chiffres sont rentrés
                {
                    trackBarLongueur.Value = Int32.Parse(Math.Round(Double.Parse(textBoxLongueur.Text)).ToString());
                    longueur = Double.Parse(textBoxLongueur.Text);
                } else
                {
                    MessageBox.Show("Veuillez rentrer des chiffres et non des lettres.");
                    textBoxLongueur.Text = "";
                }
                    
            }
        }

        private void trackBarCharge_ValueChanged(object sender, EventArgs e)
        {
            textBoxCharge.Text = trackBarCharge.Value.ToString();
            charge = trackBarCharge.Value;
        }

        private void trackBarQuadra_ValueChanged(object sender, EventArgs e)
        {
            textBoxQuadra.Text = trackBarQuadra.Value.ToString();
            quadra = trackBarQuadra.Value;
        }

        private void textBoxCharge_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCharge.Text == "")
            {
                trackBarCharge.Value = 0;
            }
            else
            {
                if (textBoxCharge.Text.All(char.IsDigit))         //Vérification que des chiffres sont rentrés
                {
                    trackBarCharge.Value = Int32.Parse(Math.Round(Double.Parse(textBoxCharge.Text)).ToString());
                    charge = Double.Parse(textBoxCharge.Text);
                }
                else
                {
                    MessageBox.Show("Veuillez rentrer des chiffres et non des lettres.");
                    textBoxCharge.Text = "";
                }
            }
        }

        private void textBoxQuadra_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuadra.Text == "")
            {
                trackBarQuadra.Value = 0;
            }
            else
            {
                if (textBoxQuadra.Text.All(char.IsDigit))         //Vérification que des chiffres sont rentrés
                {
                    trackBarQuadra.Value = Int32.Parse(Math.Round(Double.Parse(textBoxQuadra.Text)).ToString());
                    quadra = Double.Parse(textBoxQuadra.Text);
                }
                else
                {
                    MessageBox.Show("Veuillez rentrer des chiffres et non des lettres.");
                    textBoxQuadra.Text = "";
                }
            }
        }

        private void trackBarSection_ValueChanged(object sender, EventArgs e)
        {
            textBoxSection.Text = trackBarSection.Value.ToString();
            section = trackBarSection.Value;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSection.Text == "")
            {
                trackBarSection.Value = 0;
            }
            else
            {
                if (textBoxSection.Text.All(char.IsDigit))         //Vérification que des chiffres sont rentrés
                {
                    trackBarSection.Value = Int32.Parse(Math.Round(Double.Parse(textBoxSection.Text)).ToString());
                    section = Double.Parse(textBoxSection.Text);
                }
                else
                {
                    MessageBox.Show("Veuillez rentrer des chiffres et non des lettres.");
                    textBoxSection.Text = "";
                }
            }
        }
    }
}
