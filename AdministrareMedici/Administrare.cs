using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Policlinica;
using System.Threading.Tasks;

namespace AdministrareMedici
{
    public class NivelDeStocareMedic
    {
        private const int NR_MAX_MED = 20;
        public Medic[] Medici;
        public int nrMedici;

        public NivelDeStocareMedic()
        {

            Medici = new Medic[NR_MAX_MED];
            nrMedici = 0;
        }
        public void AddMedic(Medic Med)
        {
            if (nrMedici < NR_MAX_MED)
            {
                Medici[nrMedici] = Med;
                nrMedici++;

            }
            else Console.WriteLine($"Sa depasit numarul maxim de medici admisi");
        }

        public void SetMedics(Medic[] meds)
        {
            meds.CopyTo(Medici, 0);
           

        }

        public Medic[] GetMedic(out int nrMedici)
        {

            nrMedici = this.nrMedici;
            return Medici;
        }
    }
}
