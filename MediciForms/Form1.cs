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
        NivelDeStocareMedic StocareMedic;
      
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
                StocareMedic = new NivelDeStocareMedic();
            }
            catch (Exception)
            {

                MessageBox.Show("Fisierul nu Exista");
                this.Close();
            }


            StocareMedic.MediciList = AdminMedic.GetMedicsFromFile();

            if (StocareMedic.MediciList.Count == 0)
                MessageBox.Show("Fisierul este gol");
            else
            {

                InitializeDataGridView(StocareMedic.MediciList);
            }
        
        
        
        
        
        
        }

        private void buttonIntoarcere_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.Show();
           // this.Close();
        }


        void InitializeDataGridView(List<Medic> medic ) { 
        
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Medic");
            dataTable.Columns.Add("Nume");
            dataTable.Columns.Add("Prenume");
            dataTable.Columns.Add("Varsta");
            dataTable.Columns.Add("Gen");
            dataTable.Columns.Add("Specializare");
            dataTable.Columns.Add("NrTelefon"   );
            dataTable.Columns.Add("Email");
            for (int i = 0; i < medic.Count; i++ ) 
            {

                DataRow row = dataTable.NewRow();
                row["ID_Medic"] = medic[i].GetID;
                row["Nume"] = medic[i].GetNume;
                row["Prenume"] = medic[i].GetPrenume;
                row["Varsta"] = medic[i].GetVarsta;
                row["Gen"] = medic[i].GetGen;
                row["Specializare"] = medic[i].GetSpecializare;
                row["NrTelefon"] = medic[i].GetTelefon;
                row["Email"] = medic[i].GetEmail;
                dataTable.Rows.Add(row);
            }
            DataGridMedici.DataSource = dataTable;
                
        
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DataGridMedici.DataSource = null;
       
            StocareMedic.MediciList = AdminMedic.GetMedicsFromFile();

    
            if (StocareMedic.MediciList.Count == 0)
                MessageBox.Show("Fisierul este gol");
            else
            {
                InitializeDataGridView(StocareMedic.MediciList);
            }
        }
    }
}
