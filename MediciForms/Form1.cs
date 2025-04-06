using AdministrareMedici;
using Policlinica;
using Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediciForms
{
    public partial class Form1 : Form
    {
        AdministrareMediciFisier AdminMedic;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender , EventArgs e) {

           // MessageBox.Show("Fisierul este gol");
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
            int medicLength;
            Medic []vecMedic = AdminMedic.GetMedicsFromFile(out medicLength);

            List<Medic> medici = new List<Medic>();
            if (medicLength == 0)
                MessageBox.Show("Fisierul este gol");
            else
            {

                foreach (Medic med in vecMedic)
                {
                    medici.Add(med);
                }
                DataGridMedici.DataSource = medici;
            }
        
        
        
        
        
        
        }

        private void buttonIntoarcere_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.Show();
           // this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            int medicLength;
            Medic[] vecMedic = AdminMedic.GetMedicsFromFile(out medicLength);

            List<Medic> medici = new List<Medic>();
            if (medicLength == 0)
                MessageBox.Show("Fisierul este gol");
            else
            {

                foreach (Medic med in vecMedic)
                {
                    medici.Add(med);
                }
                DataGridMedici.DataSource = medici;
            }
        }
    }
}
