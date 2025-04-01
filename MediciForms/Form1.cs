using AdministrareMedici;
using Policlinica;
using Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Program.FisierConfigurari;



namespace MediciForms
{
    public partial class Form1: Form
    {


        private Label lblNumePrenume;
        private Label lblID;
        private Label lblGen;
        private Label lblEmail;
        private Label lblNrTelefon;
        private Label lblSpecializare;
        private Label lblVarsta;

        private Label[] lblsNumePrenume;
        private Label[] lblsID;
        private Label[] lblsGen;
        private Label[] lblsEmail;
        private Label[] lblsNrTelefon;
        private Label[] lblsSpecialitate;
        private Label[] lblsVarsta;
        private const int MOVE_X = 100;
        private const int MOVE_Y = 50;
        private const int LATIME_CONTROL = 100;
       AdministrareMediciFisier AdminMedic = new AdministrareMediciFisier();
           // NivelDeStocareMedic meds = new NivelDeStocareMedic();
        public Form1()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings.Get("File Name");
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\ConsoleApp1\\bin\\Debug\\medici.txt";
            Console.WriteLine(caleCompletaFisier);
            AdminMedic.SetFileName(caleCompletaFisier);

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumePrenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NrTelefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Specializare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaStudenti();

        }
        private void AfiseazaStudenti()
        {
            int nrMedici;
            Medic [] Medics = AdminMedic.GetMedicsFromFile(out nrMedici );



             lblsNumePrenume = new Label[nrMedici];
             lblsID = new Label[nrMedici];
             lblsGen = new Label[nrMedici];
             lblsEmail = new Label[nrMedici];
             lblsNrTelefon = new Label[nrMedici];
             lblsSpecialitate = new Label[nrMedici];
             lblsVarsta = new Label[nrMedici];

        int i = 0;
            foreach (Medic medic in Medics)
            {
                if (i >= nrMedici) break;
                //adaugare control de tip Label pentru numele studentilor;
                lblsID[i] = new Label();
                lblsID[i].Width = LATIME_CONTROL;
                lblsID[i].Text = medic.GetID.ToString() ;
                lblsID[i].Left =  label7.Location.X + 0 * MOVE_X;
                lblsID[i].Top = label1.Location.Y +  (i + 1) * MOVE_Y;
                lblsID[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.Controls.Add(lblsID[i]);

                //adaugare control de tip Label pentru prenumele studentilor
                lblsNumePrenume[i] = new Label();
                lblsNumePrenume[i].Width = LATIME_CONTROL;
                lblsNumePrenume[i].Text = medic.numeComplet;
                lblsNumePrenume[i].Left = label7.Location.X + 1 * MOVE_X;
                lblsNumePrenume[i].Top = label1.Location.Y +   (i + 1) * MOVE_Y;
                this.Controls.Add(lblsNumePrenume[i]);

                //adaugare control de tip Label pentru notele studentilor
                lblsVarsta[i] = new Label();
                lblsVarsta[i].Width = LATIME_CONTROL;
                lblsVarsta[i].Text = medic.age.ToString();
                lblsVarsta[i].Left = label7.Location.X + 2 * MOVE_X;
                lblsVarsta[i].Top = label1.Location.Y + (i + 1) * MOVE_Y;
                this.Controls.Add(lblsVarsta[i]);



                lblsGen[i] = new Label();
                lblsGen[i].Width = LATIME_CONTROL;
                lblsGen[i].Text = medic.Gen.ToString();
                lblsGen[i].Left = label7.Location.X + 3 * MOVE_X;
                lblsGen[i].Top = label1.Location.Y + (i + 1) * MOVE_Y;
                this.Controls.Add(lblsGen[i]);


                lblsSpecialitate[i] = new Label();
                lblsSpecialitate[i].Width = LATIME_CONTROL;
                lblsSpecialitate[i].Text = medic.GetSpecializare;
                lblsSpecialitate[i].Left = label7.Location.X + 4 * MOVE_X;
                lblsSpecialitate[i].Top = label1.Location.Y + (i + 1) * MOVE_Y;
                this.Controls.Add(lblsSpecialitate[i]);


                lblsNrTelefon[i] = new Label();
                lblsNrTelefon[i].Width = LATIME_CONTROL;
                lblsNrTelefon[i].Text = medic.nrTelefon;
                lblsNrTelefon[i].Left = label7.Location.X + 5 * MOVE_X;
                lblsNrTelefon[i].Top = label1.Location.Y + (i + 1) * MOVE_Y;
                this.Controls.Add(lblsNrTelefon[i]);

                lblsEmail[i] = new Label();
                lblsEmail[i].Width = LATIME_CONTROL;
                lblsEmail[i].Text = medic.email;
                lblsEmail[i].Left = label7.Location.X + 6 * MOVE_X;
                lblsEmail[i].Top = label1.Location.Y + (i + 1) * MOVE_Y;
                this.Controls.Add(lblsEmail[i]);
                i++;
                
            }
        }
    }
}
