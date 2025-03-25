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
        private const int NR_MAX_MEDICI = 20;
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
        public Medic[] GetMedicsFromFile(out int nrMedics)
        {
            Medic[] meds = new Medic[NR_MAX_MEDICI];
            using (StreamReader readFileMedics = new StreamReader(fileName))
            {
                string line;
                nrMedics = 0;
                while ((line = readFileMedics.ReadLine()) != null)
                {
                    meds[nrMedics] = new Medic(line);
                    nrMedics++;
                }

            }
            
            return meds;

        }
    }
}
