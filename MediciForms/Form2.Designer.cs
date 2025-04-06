using Policlinica;
using System;

namespace MediciForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelSpecialitate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textVarsta = new System.Windows.Forms.TextBox();
            this.comboBoxSpecializare = new System.Windows.Forms.ComboBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.ButonValidare = new System.Windows.Forms.Button();
            this.buttonVizualizareMedici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(92, 55);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(248, 55);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Location = new System.Drawing.Point(248, 146);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(37, 13);
            this.labelVarsta.TabIndex = 2;
            this.labelVarsta.Text = "Varsta";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(399, 55);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(27, 13);
            this.labelGen.TabIndex = 3;
            this.labelGen.Text = "Gen";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(72, 227);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(77, 13);
            this.labelTelefon.TabIndex = 4;
            this.labelTelefon.Text = "Numar Telefon";
            // 
            // labelSpecialitate
            // 
            this.labelSpecialitate.AutoSize = true;
            this.labelSpecialitate.Location = new System.Drawing.Point(399, 146);
            this.labelSpecialitate.Name = "labelSpecialitate";
            this.labelSpecialitate.Size = new System.Drawing.Size(64, 13);
            this.labelSpecialitate.TabIndex = 5;
            this.labelSpecialitate.Text = "Specializare";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(92, 146);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(59, 92);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 7;
            this.textNume.TextChanged += new System.EventHandler(this.textNume_TextChanged);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(219, 92);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 8;
            this.textPrenume.TextChanged += new System.EventHandler(this.textPrenume_TextChanged);
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.comboBoxGen.Location = new System.Drawing.Point(365, 92);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGen.TabIndex = 10;
            this.comboBoxGen.SelectedIndexChanged += new System.EventHandler(this.comboBoxGen_SelectedIndexChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(59, 178);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 11;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textVarsta
            // 
            this.textVarsta.Location = new System.Drawing.Point(219, 178);
            this.textVarsta.Name = "textVarsta";
            this.textVarsta.Size = new System.Drawing.Size(100, 20);
            this.textVarsta.TabIndex = 12;
            this.textVarsta.TextChanged += new System.EventHandler(this.textVarsta_TextChanged);
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Location = new System.Drawing.Point(365, 178);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecializare.TabIndex = 14;
            this.comboBoxSpecializare.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecializare_SelectedIndexChanged);
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(59, 267);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(100, 20);
            this.textTelefon.TabIndex = 15;
            this.textTelefon.TextChanged += new System.EventHandler(this.textTelefon_TextChanged);
            // 
            // ButonValidare
            // 
            this.ButonValidare.Location = new System.Drawing.Point(59, 312);
            this.ButonValidare.Name = "ButonValidare";
            this.ButonValidare.Size = new System.Drawing.Size(436, 23);
            this.ButonValidare.TabIndex = 16;
            this.ButonValidare.Text = "Submit";
            this.ButonValidare.UseVisualStyleBackColor = true;
            this.ButonValidare.Click += new System.EventHandler(this.ButonValidare_Click);
            // 
            // buttonVizualizareMedici
            // 
            this.buttonVizualizareMedici.AutoSize = true;
            this.buttonVizualizareMedici.Location = new System.Drawing.Point(663, 391);
            this.buttonVizualizareMedici.Name = "buttonVizualizareMedici";
            this.buttonVizualizareMedici.Size = new System.Drawing.Size(100, 23);
            this.buttonVizualizareMedici.TabIndex = 17;
            this.buttonVizualizareMedici.Text = "Vizualizare medici";
            this.buttonVizualizareMedici.UseVisualStyleBackColor = true;
            this.buttonVizualizareMedici.Click += new System.EventHandler(this.buttonVizualizareMedici_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVizualizareMedici);
            this.Controls.Add(this.ButonValidare);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.comboBoxSpecializare);
            this.Controls.Add(this.textVarsta);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.comboBoxGen);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSpecialitate);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.labelVarsta);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelSpecialitate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textVarsta;
        private System.Windows.Forms.ComboBox comboBoxSpecializare;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Button ButonValidare;
        public System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.Button buttonVizualizareMedici;
    }
}