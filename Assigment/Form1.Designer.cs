namespace Assigment
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxForme = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxLongueur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxQuadra = new System.Windows.Forms.TextBox();
            this.textBoxYoung = new System.Windows.Forms.TextBox();
            this.flecheAssociee = new System.Windows.Forms.Label();
            this.flecheMax = new System.Windows.Forms.Label();
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCharge = new System.Windows.Forms.TextBox();
            this.buttonAbaque = new System.Windows.Forms.Button();
            this.buttonSauvegarde = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.trackBarLongueur = new System.Windows.Forms.TrackBar();
            this.comboBoxMateriaux = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBarCharge = new System.Windows.Forms.TrackBar();
            this.trackBarQuadra = new System.Windows.Forms.TrackBar();
            this.labelValidite = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.trackBarSection = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLongueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuadra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcul de flèches pour une poutre encastrée";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caractéristiques de la poutre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Forme de la section :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Moment quadratique (m^4) : [0;1000]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Module d\'Young (N/m²) :";
            // 
            // comboBoxForme
            // 
            this.comboBoxForme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForme.FormattingEnabled = true;
            this.comboBoxForme.Items.AddRange(new object[] {
            "Circulaire",
            "Rectangulaire"});
            this.comboBoxForme.Location = new System.Drawing.Point(607, 100);
            this.comboBoxForme.Name = "comboBoxForme";
            this.comboBoxForme.Size = new System.Drawing.Size(121, 24);
            this.comboBoxForme.TabIndex = 6;
            this.comboBoxForme.SelectedIndexChanged += new System.EventHandler(this.comboBoxForme_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Résultat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Flèche associée :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Flèche maximale :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBoxLongueur
            // 
            this.textBoxLongueur.Location = new System.Drawing.Point(607, 140);
            this.textBoxLongueur.Name = "textBoxLongueur";
            this.textBoxLongueur.Size = new System.Drawing.Size(121, 22);
            this.textBoxLongueur.TabIndex = 10;
            this.textBoxLongueur.TextChanged += new System.EventHandler(this.textBoxLongueur_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Longueur (m) : [0;50]";
            // 
            // textBoxQuadra
            // 
            this.textBoxQuadra.Location = new System.Drawing.Point(607, 262);
            this.textBoxQuadra.Name = "textBoxQuadra";
            this.textBoxQuadra.Size = new System.Drawing.Size(121, 22);
            this.textBoxQuadra.TabIndex = 12;
            this.textBoxQuadra.TextChanged += new System.EventHandler(this.textBoxQuadra_TextChanged);
            // 
            // textBoxYoung
            // 
            this.textBoxYoung.Location = new System.Drawing.Point(607, 342);
            this.textBoxYoung.Name = "textBoxYoung";
            this.textBoxYoung.Size = new System.Drawing.Size(121, 22);
            this.textBoxYoung.TabIndex = 13;
            this.textBoxYoung.TextChanged += new System.EventHandler(this.textBoxYoung_TextChanged);
            // 
            // flecheAssociee
            // 
            this.flecheAssociee.AutoSize = true;
            this.flecheAssociee.Location = new System.Drawing.Point(249, 476);
            this.flecheAssociee.Name = "flecheAssociee";
            this.flecheAssociee.Size = new System.Drawing.Size(54, 17);
            this.flecheAssociee.TabIndex = 14;
            this.flecheAssociee.Text = "label10";
            // 
            // flecheMax
            // 
            this.flecheMax.AutoSize = true;
            this.flecheMax.Location = new System.Drawing.Point(249, 512);
            this.flecheMax.Name = "flecheMax";
            this.flecheMax.Size = new System.Drawing.Size(54, 17);
            this.flecheMax.TabIndex = 15;
            this.flecheMax.Text = "label11";
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(360, 394);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(368, 30);
            this.buttonCalcul.TabIndex = 16;
            this.buttonCalcul.Text = "Calculer";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Charge en bout (N) : [0;1500]";
            // 
            // textBoxCharge
            // 
            this.textBoxCharge.Location = new System.Drawing.Point(607, 222);
            this.textBoxCharge.Name = "textBoxCharge";
            this.textBoxCharge.Size = new System.Drawing.Size(121, 22);
            this.textBoxCharge.TabIndex = 18;
            this.textBoxCharge.TextChanged += new System.EventHandler(this.textBoxCharge_TextChanged);
            // 
            // buttonAbaque
            // 
            this.buttonAbaque.Location = new System.Drawing.Point(806, 305);
            this.buttonAbaque.Name = "buttonAbaque";
            this.buttonAbaque.Size = new System.Drawing.Size(159, 30);
            this.buttonAbaque.TabIndex = 19;
            this.buttonAbaque.Text = "Choix abaque";
            this.buttonAbaque.UseVisualStyleBackColor = true;
            this.buttonAbaque.Click += new System.EventHandler(this.buttonAbaque_Click);
            // 
            // buttonSauvegarde
            // 
            this.buttonSauvegarde.Location = new System.Drawing.Point(806, 394);
            this.buttonSauvegarde.Name = "buttonSauvegarde";
            this.buttonSauvegarde.Size = new System.Drawing.Size(159, 30);
            this.buttonSauvegarde.TabIndex = 20;
            this.buttonSauvegarde.Text = "Sauvegarde calculs";
            this.buttonSauvegarde.UseVisualStyleBackColor = true;
            this.buttonSauvegarde.Click += new System.EventHandler(this.buttonSauvegarde_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // trackBarLongueur
            // 
            this.trackBarLongueur.Location = new System.Drawing.Point(759, 140);
            this.trackBarLongueur.Maximum = 50;
            this.trackBarLongueur.Name = "trackBarLongueur";
            this.trackBarLongueur.Size = new System.Drawing.Size(260, 56);
            this.trackBarLongueur.TabIndex = 21;
            this.trackBarLongueur.ValueChanged += new System.EventHandler(this.trackBarLongueur_ValueChanged);
            // 
            // comboBoxMateriaux
            // 
            this.comboBoxMateriaux.FormattingEnabled = true;
            this.comboBoxMateriaux.Location = new System.Drawing.Point(607, 302);
            this.comboBoxMateriaux.Name = "comboBoxMateriaux";
            this.comboBoxMateriaux.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMateriaux.Sorted = true;
            this.comboBoxMateriaux.TabIndex = 22;
            this.comboBoxMateriaux.Text = "Séléctionner un matériau";
            this.comboBoxMateriaux.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateriaux_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Matériaux :";
            // 
            // trackBarCharge
            // 
            this.trackBarCharge.Location = new System.Drawing.Point(759, 222);
            this.trackBarCharge.Maximum = 1500;
            this.trackBarCharge.Name = "trackBarCharge";
            this.trackBarCharge.Size = new System.Drawing.Size(260, 56);
            this.trackBarCharge.TabIndex = 24;
            this.trackBarCharge.ValueChanged += new System.EventHandler(this.trackBarCharge_ValueChanged);
            // 
            // trackBarQuadra
            // 
            this.trackBarQuadra.Location = new System.Drawing.Point(759, 262);
            this.trackBarQuadra.Maximum = 1000;
            this.trackBarQuadra.Name = "trackBarQuadra";
            this.trackBarQuadra.Size = new System.Drawing.Size(260, 56);
            this.trackBarQuadra.TabIndex = 25;
            this.trackBarQuadra.ValueChanged += new System.EventHandler(this.trackBarQuadra_ValueChanged);
            // 
            // labelValidite
            // 
            this.labelValidite.AutoSize = true;
            this.labelValidite.Location = new System.Drawing.Point(437, 491);
            this.labelValidite.Name = "labelValidite";
            this.labelValidite.Size = new System.Drawing.Size(54, 17);
            this.labelValidite.TabIndex = 26;
            this.labelValidite.Text = "label12";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(357, 185);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(141, 17);
            this.labelSection.TabIndex = 27;
            this.labelSection.Text = "Section (dm²) : [0;40]";
            // 
            // textBoxSection
            // 
            this.textBoxSection.Location = new System.Drawing.Point(607, 182);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(121, 22);
            this.textBoxSection.TabIndex = 28;
            this.textBoxSection.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // trackBarSection
            // 
            this.trackBarSection.Location = new System.Drawing.Point(759, 182);
            this.trackBarSection.Maximum = 40;
            this.trackBarSection.Name = "trackBarSection";
            this.trackBarSection.Size = new System.Drawing.Size(260, 56);
            this.trackBarSection.TabIndex = 29;
            this.trackBarSection.ValueChanged += new System.EventHandler(this.trackBarSection_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 561);
            this.Controls.Add(this.trackBarSection);
            this.Controls.Add(this.textBoxSection);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelValidite);
            this.Controls.Add(this.trackBarQuadra);
            this.Controls.Add(this.trackBarCharge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxMateriaux);
            this.Controls.Add(this.trackBarLongueur);
            this.Controls.Add(this.buttonSauvegarde);
            this.Controls.Add(this.buttonAbaque);
            this.Controls.Add(this.textBoxCharge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonCalcul);
            this.Controls.Add(this.flecheMax);
            this.Controls.Add(this.flecheAssociee);
            this.Controls.Add(this.textBoxYoung);
            this.Controls.Add(this.textBoxQuadra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxLongueur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxForme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLongueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuadra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxForme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxLongueur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxQuadra;
        private System.Windows.Forms.TextBox textBoxYoung;
        private System.Windows.Forms.Label flecheAssociee;
        private System.Windows.Forms.Label flecheMax;
        private System.Windows.Forms.Button buttonCalcul;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCharge;
        private System.Windows.Forms.Button buttonAbaque;
        private System.Windows.Forms.Button buttonSauvegarde;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TrackBar trackBarLongueur;
        private System.Windows.Forms.ComboBox comboBoxMateriaux;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarCharge;
        private System.Windows.Forms.TrackBar trackBarQuadra;
        private System.Windows.Forms.Label labelValidite;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.TrackBar trackBarSection;
    }
}

