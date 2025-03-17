using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica
{
    public class Persoana
    {
        private const char SEP = ';';
        public string Nume;
        public string Prenume;
        public int age;
        public char Gen;
        public string nrTelefon;
        public string email;
        public string numeComplet
        {
            get { return Nume + " " + Prenume; }
        }

        public Persoana()
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            age = 0;
            Gen = '?';
            nrTelefon = string.Empty;
        }
        public Persoana(string _nume, string _prenume, int _age, char _gen, string _nrTelefon, string _email)
        {
            Nume = _nume;
            Prenume = _prenume;
            this.age = _age;
            Gen = _gen;
            this.nrTelefon = _nrTelefon;
            email = _email;
        }

        public virtual string InfoPers()
        {
            return $"Nume/Prenume:[{numeComplet ?? "Necunoscut"}] Varsta:[{age}]\n GEN:[{(Gen == 'M' ? "Masculin" : "Feminim")}]\n NrTelefon:[{nrTelefon ?? "Necunoscut"}]\n email:[{email ?? "Necunoscut"}]  ";
        }

        public virtual string ToStrForFile()
        {
            string fileFormat = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEP,
                (Nume ?? "Necunoscut"),
                (Prenume ?? "Necunoscut"),
                (age.ToString() ?? "Necunoscut"),
                (Gen),
                (nrTelefon ?? "Necunoscut"),
                (email ?? "Necunoscut")
                );
             
            return fileFormat;
        }

    }
}
