using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica
{
    class Pacient : Persoana
    {
        public int IdPacient { get; set; }
        static int ID = 0;
        public Pacient(Persoana pers) : base(pers.Nume, pers.Prenume, pers.age, pers.Gen, pers.nrTelefon, pers.email)
        {
            IdPacient = ID++;
        }
        public Pacient(string _nume, string _prenume, int _age, char _gen, string _nrTelefon, string _email) : base(_nume, _prenume, _age, _gen, _nrTelefon, _email)
        {
            IdPacient = ID++;
        }

        public override string InfoPers()
        {
            return string.Format("{0} {1}", (IdPacient.ToString() ?? "Necunoscut"), base.InfoPers());
            //return $"Nume/Prenume:[{numeComplet ?? "Necunoscut"}] Varsta:[{age}]\n GEN:[{(Gen == 'M' ? "Masculin" : "Feminim")}]\n NrTelefon:[{nrTelefon ?? "Necunoscut"}]\n email:[{email ?? "Necunoscut"}]  ";
        }


    }
}
