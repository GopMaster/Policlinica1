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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(384, 101);
            this.labelNume.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(58, 22);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPrenume.Location = new System.Drawing.Point(722, 101);
            this.labelPrenume.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(83, 22);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelVarsta.Location = new System.Drawing.Point(527, 208);
            this.labelVarsta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(63, 22);
            this.labelVarsta.TabIndex = 2;
            this.labelVarsta.Text = "Varsta";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelGen.Location = new System.Drawing.Point(384, 208);
            this.labelGen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(44, 22);
            this.labelGen.TabIndex = 3;
            this.labelGen.Text = "Gen";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTelefon.Location = new System.Drawing.Point(335, 301);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(132, 22);
            this.labelTelefon.TabIndex = 4;
            this.labelTelefon.Text = "Numar Telefon";
            // 
            // labelSpecialitate
            // 
            this.labelSpecialitate.AutoSize = true;
            this.labelSpecialitate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelSpecialitate.Location = new System.Drawing.Point(696, 208);
            this.labelSpecialitate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSpecialitate.Name = "labelSpecialitate";
            this.labelSpecialitate.Size = new System.Drawing.Size(109, 22);
            this.labelSpecialitate.TabIndex = 5;
            this.labelSpecialitate.Text = "Specializare";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelEmail.Location = new System.Drawing.Point(747, 301);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 22);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(305, 136);
            this.textNume.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(231, 24);
            this.textNume.TabIndex = 7;
            this.textNume.Enter += new System.EventHandler(this.textNume_Enter);
            this.textNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNume_KeyDown);
            this.textNume.Leave += new System.EventHandler(this.textNume_Leave);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(650, 136);
            this.textPrenume.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(231, 24);
            this.textPrenume.TabIndex = 8;
            this.textPrenume.Enter += new System.EventHandler(this.textPrenume_Enter);
            this.textPrenume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPrenume_KeyDown);
            this.textPrenume.Leave += new System.EventHandler(this.textPrenume_Leave);
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.comboBoxGen.Location = new System.Drawing.Point(305, 246);
            this.comboBoxGen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(162, 26);
            this.comboBoxGen.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(639, 344);
            this.textEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(242, 24);
            this.textEmail.TabIndex = 11;
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEmail_KeyDown);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textVarsta
            // 
            this.textVarsta.Location = new System.Drawing.Point(511, 246);
            this.textVarsta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textVarsta.Name = "textVarsta";
            this.textVarsta.Size = new System.Drawing.Size(91, 24);
            this.textVarsta.TabIndex = 12;
            this.textVarsta.Enter += new System.EventHandler(this.textVarsta_Enter);
            this.textVarsta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textVarsta_KeyDown);
            this.textVarsta.Leave += new System.EventHandler(this.textVarsta_Leave);
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Location = new System.Drawing.Point(639, 246);
            this.comboBoxSpecializare.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(242, 26);
            this.comboBoxSpecializare.TabIndex = 14;
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(305, 344);
            this.textTelefon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(171, 24);
            this.textTelefon.TabIndex = 15;
            this.textTelefon.Enter += new System.EventHandler(this.textTelefon_Enter);
            this.textTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTelefon_KeyDown);
            this.textTelefon.Leave += new System.EventHandler(this.textTelefon_Leave);
            // 
            // ButonValidare
            // 
            this.ButonValidare.Location = new System.Drawing.Point(258, 416);
            this.ButonValidare.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButonValidare.Name = "ButonValidare";
            this.ButonValidare.Size = new System.Drawing.Size(685, 62);
            this.ButonValidare.TabIndex = 16;
            this.ButonValidare.Text = "Submit";
            this.ButonValidare.UseVisualStyleBackColor = true;
            this.ButonValidare.Click += new System.EventHandler(this.ButonValidare_Click);
            // 
            // buttonVizualizareMedici
            // 
            this.buttonVizualizareMedici.AutoSize = true;
            this.buttonVizualizareMedici.Location = new System.Drawing.Point(1053, 540);
            this.buttonVizualizareMedici.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonVizualizareMedici.Name = "buttonVizualizareMedici";
            this.buttonVizualizareMedici.Size = new System.Drawing.Size(167, 32);
            this.buttonVizualizareMedici.TabIndex = 17;
            this.buttonVizualizareMedici.Text = "Vizualizare medici";
            this.buttonVizualizareMedici.UseVisualStyleBackColor = true;
            this.buttonVizualizareMedici.Click += new System.EventHandler(this.buttonVizualizareMedici_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Introducere date medic";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Inregistrare Medic";
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
        private System.Windows.Forms.Label label1;
    }
}