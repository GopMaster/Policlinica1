using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Policlinica;
namespace AdministrareMedici
{
    public class AdministrareMediciFisier
    {
        //NivelDeStocareMedic StocareMedic = new NivelDeStocareMedic();
        public static string fileName = "Medics.txt";


        public AdministrareMediciFisier(string _fileName)
        {
            fileName = _fileName;
            Stream streamFileText = File.Open(_fileName, FileMode.OpenOrCreate);
            streamFileText.Close();
        }
        public AdministrareMediciFisier() {
            fileName = string.Empty;

        }
        public void AddMedicToFile(Medic Med)
        {

            using (StreamWriter streamWriteMedicToFile = new StreamWriter(fileName, true))
            {
                streamWriteMedicToFile.WriteLine(Med.ToStrForFile());
            }

        }
        public void SetFileName(string _fileName) {
            fileName = _fileName;
            Stream StreamFile = File.Open(_fileName, FileMode.OpenOrCreate);
            StreamFile.Close();
        
        
        }

       
        
        
        public List<Medic> GetMedicsFromFile()
        {
            List<Medic> tempList = new List<Medic>(); 
            using (StreamReader readFileMedics = new StreamReader(fileName))
            {
                string line;
          
                while ((line = readFileMedics.ReadLine()) != null)
                {
                   Medic temp_med = new Medic(line);
                    tempList.Add(temp_med);
                   
                }

            }
            
            return tempList;

        }
    }
}
