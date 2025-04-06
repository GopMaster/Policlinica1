using AdministrareMedici;
using Policlinica;
using Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediciForms
{
    public partial class Form2 : Form
    {
        private AdministrareMediciFisier AdminMedic;
        private int NR_MAX_CARACTERE = 15;
        private Form form1; 

        public Form2(Form _form1) {
            InitializeComponent();
            this.form1 = _form1;
            
        }
        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
               // MessageBox.Show(FisierConfigurari.GetFileNameConf());

                AdminMedic = new AdministrareMediciFisier(FisierConfigurari.GetFileNameConf());
            }
            catch (Exception)
            {

                MessageBox.Show("Fisierul nu Exista");
                this.Close();
            }

            DoctorType[] doctortypes = (DoctorType[])Enum.GetValues(typeof(DoctorType));
            //int s = doctortypes.Length;
            // List<string> doctortypestring 
            foreach (DoctorType i in doctortypes)
            {
                Console.WriteLine(i.ToString());
                comboBoxSpecializare.Items.Add(i.ToString());
                //ButonValidare.Text = i.ToString();

            }





        }


        public bool FunctieValidareText(string sample, string RegexValidation)
        {

            return Regex.IsMatch(sample, RegexValidation);
        }



        public bool NumeValidation(string nume ) {
            
            if (string.IsNullOrWhiteSpace(nume))
            {
                textNume.BackColor = Color.Red;
                return false;
            }
            else
            {
                textNume.BackColor = Color.White;
            }
            if (!FunctieValidareText(nume, @"^[A-Za-z]+$"))
            {
                textNume.BackColor = Color.Red;
                return false;
            }
            if (nume.Length > NR_MAX_CARACTERE) {
                textNume.BackColor = Color.Red;
                return false;
            }
            return true;
        }
       
        
        public bool PrenumeValidation(string prenume) {

           
            if (string.IsNullOrWhiteSpace(prenume))
            {
                textPrenume.BackColor = Color.Red;
                return false;
            }
            else
            {
                textPrenume.BackColor = Color.White;
            }
            if (!FunctieValidareText(prenume, @"^[A-Za-z]+$"))
            {
                textPrenume.BackColor = Color.Red;
                return false;
            }
            else { textPrenume.BackColor = Color.White; }
            if (prenume.Length > NR_MAX_CARACTERE)
            {
                textPrenume.BackColor = Color.Red;
                return false;
            }
            return true;
        }
      
        public bool EmailValidation(string email) {

           
            if (string.IsNullOrWhiteSpace(email))
            {
                textEmail.BackColor = Color.Red;
                return false;
            }
            else
            {
                textEmail.BackColor = Color.White;
            }
            if (!FunctieValidareText(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                textEmail.BackColor = Color.Red;
                return false;
            }
            else { textEmail.BackColor = Color.White; }
                return true;
        }

        
        
        
        public bool VarstaValidare(string varsta) {
           
            if (string.IsNullOrWhiteSpace(varsta))
            {
                textVarsta.BackColor = Color.Red;
                return false;
            }
            else
            {
                textVarsta.BackColor = Color.White;
            }
            if (!FunctieValidareText(varsta, @"^(120|1[01][0-9]|[1-9]?[0-9])$"))
            {
                
                    textVarsta.BackColor = Color.Red;
                    return false;
                
            }
            else { 
                textVarsta.BackColor = Color.White;
            }
            int varsta_int;
            varsta_int = Int32.Parse(varsta);
            if (varsta_int < 18)
            {
                textVarsta.BackColor = Color.Red;
                return false; 
            }
            else{ textVarsta.BackColor = Color.White; }
                return true;

        }


        public bool NumarValidation(string Numar) 
        {
           
            if (string.IsNullOrWhiteSpace(Numar))
            {
                textTelefon.BackColor = Color.Red;
                return false;
            }
            else
            {
                textTelefon.BackColor = Color.White;
            }
            if (!FunctieValidareText(Numar, @"^(072|073|074|075|076|077|078)\d{7}$"))
            {
                textTelefon.BackColor = Color.Red;
                return false;
            } else
            { textTelefon.BackColor = Color.White; }
            return true;

        }

        public bool GenValidare(string gen)
        {
          
            if (string.IsNullOrWhiteSpace(gen))
            {
                comboBoxGen.BackColor = Color.Red;
                return false;
            }
            else {
                comboBoxGen.BackColor = Color.White;
            }
            return true;

        }

        public bool SpecializareValidare(string specializare)
        {
            
            if (string.IsNullOrWhiteSpace(specializare))
            {
                comboBoxSpecializare.BackColor = Color.Red;
                return false;
            }
            else
            {
                comboBoxSpecializare.BackColor = Color.White;
            }
            return true;

        }


        public bool Validare() {
            
            string nume = textNume.Text.Trim();
            if (!NumeValidation(nume)) {
                return false;
            }
            string prenume = textPrenume.Text.Trim();
            if (!PrenumeValidation(prenume)) {
                return false;
            }
            string email = textEmail.Text.Trim();
            if (!EmailValidation(email)) {
                return false;
            }
            string varsta = textVarsta.Text.Trim();
            if (!VarstaValidare(varsta)) {
                return false;
            }
            string Numar = textTelefon.Text.Trim();
            if (!NumarValidation(Numar)) {
                return false;
            }
            string gen = comboBoxGen.SelectedItem.ToString();
            if (!GenValidare(gen)) {
                return false;
            }
            string specializare = comboBoxSpecializare.SelectedItem.ToString();
            if (!SpecializareValidare(specializare)) {
                return false;
            }
            return true;
        }

        private void textNume_TextChanged(object sender, EventArgs e)
        {
            string nume = textNume.Text.Trim();
            NumeValidation(nume);
        }

        private void textPrenume_TextChanged(object sender, EventArgs e)
        {
            string prenume = textPrenume.Text.Trim();
            PrenumeValidation(prenume);
           
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            EmailValidation(email);
            
        }

        private void textVarsta_TextChanged(object sender, EventArgs e)
        {
            string varsta = textVarsta.Text.Trim();
            VarstaValidare(varsta);
          

        }

        private void comboBoxGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gen = comboBoxGen.SelectedItem.ToString();
            GenValidare(gen);         
        }

        private void comboBoxSpecializare_SelectedIndexChanged(object sender, EventArgs e)
        {
            string specializare = comboBoxSpecializare.SelectedItem.ToString();
            SpecializareValidare(specializare);
           
        }

        private void textTelefon_TextChanged(object sender, EventArgs e)
        {
            string Numar = textTelefon.Text.Trim();
            NumarValidation(Numar);

        }


        

        private void ButonValidare_Click(object sender, EventArgs e)
        {// Scriere in fisier 
            if (Validare())
            {
                char gen = (comboBoxGen.Text.Trim() == "Masculin" ? 'M' : 'F');
                Medic stud = new Medic(textNume.Text.Trim(), textPrenume.Text.Trim(), Int32.Parse(textVarsta.Text.Trim()), gen, textTelefon.Text.Trim(), textEmail.Text.Trim(), comboBoxSpecializare.Text.Trim());
                AdminMedic.AddMedicToFile(stud);
                textNume.Clear();
                textPrenume.Clear();
                textVarsta.Clear();
                textEmail.Clear();
                comboBoxGen.Text = string.Empty;
                comboBoxSpecializare.Text = string.Empty;
                textTelefon.Clear();
                
            }
            else {

                MessageBox.Show("Nu a reusit Validarea");
            }
        }

        private void buttonVizualizareMedici_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Show();
            //this.Close();
        }
    }
}