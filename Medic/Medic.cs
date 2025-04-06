using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica
{
    public class Medic : Persoana
    {


        private const char SEPARATOR = ';';
        string Specializare;
        public string GetSpecializare
        {
            get { return Specializare; }
        }
        int NrOperatiuni;
        static int ID = 0 ;

        int IdMedic;
        public int GetID {
            get { return IdMedic; }
        }
        public char GetGen {
            get { return Gen; }
         }
        public string GetEmail {
            get { return email; }
        }
        public string GetTelefon {
            get { return nrTelefon; }
        }
        public int GetVarsta {
            get { return age; }
        }
        public string GetNume {
            get { return Nume; }
        }
        public string GetPrenume {
            get { return Prenume; }
        }

        public Medic() : base()
        {
            Specializare = string.Empty;


        }
        public Medic(Persoana pers, string _Specializare) : base(pers.Nume, pers.Prenume, pers.age, pers.Gen, pers.nrTelefon, pers.email)
        {
            Specializare = _Specializare;
            NrOperatiuni = 0;
            IdMedic = ID++;
        }
        public Medic(string _nume, string _prenume, int _age, char _gen, string _nrTelefon, string _email, string _Specializare) : base(_nume, _prenume, _age, _gen, _nrTelefon, _email)
        {
            Specializare = _Specializare;
            NrOperatiuni = 0;
            IdMedic = ID++;

        }
      
        public Medic(string fileLine)
        {
            if (fileLine != string.Empty)
            {

                var dateFisier = fileLine.Split(SEPARATOR);
                IdMedic = Convert.ToInt32(dateFisier[(int)Part.E_ID]);
                Nume = dateFisier[(int)Part.E_NUME];
                Prenume = dateFisier[(int)Part.E_PRENUME];
                age = Convert.ToInt32(dateFisier[(int)Part.E_AGE]);
                Gen = dateFisier[(int)Part.E_GEN][0];
                nrTelefon = dateFisier[(int)Part.E_NRTELEFON];
                email = dateFisier[(int)Part.E_EMAIL];
                Specializare = dateFisier[(int)Part.E_SPECIALIZARE];
                NrOperatiuni = Convert.ToInt32(dateFisier[(int)Part.E_NROPS]);
            }
            else
                throw new InvalidProgramException("Blank line read from file"); 
        }

        public override string InfoPers()
        {
            return string.Format("ID{0} TIP_MEDIC[{1}]\n {2} ", IdMedic.ToString(),Specializare, base.InfoPers());
        }
        public void FinalizareOp()
        {
            NrOperatiuni++;
        }

        public override string ToStrForFile()
        {
            string MedicFileFormat = string.Format("{1}{0}{2}{3}{0}{4}",

                SEPARATOR,
                IdMedic.ToString(),
                base.ToStrForFile(),
                Specializare,
                NrOperatiuni.ToString()
                );
            return MedicFileFormat;
        }

    }
}
