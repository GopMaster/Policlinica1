using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Policlinica;

using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Security.Policy;

namespace AdministrareMedici
{
    public class NivelDeStocareMedic
    {
       
        public List<Medic> MediciList;
        //public int nrMedici;

        public NivelDeStocareMedic() {
            MediciList = new List<Medic>();

        }

        public void AddMedic(Medic Med)
        {

            MediciList.Add(Med);
        }

        public void SetMedics(List<Medic> meds)
        {
            MediciList.Clear();
            foreach (var medic in meds) {

                MediciList.Add(medic);
            }
           

        }

        public List<Medic> GetMedic()
        {

            
            return MediciList;
        }
        public void FindMedic()
        {
            if (MediciList.Count == 0)
            {
                Console.WriteLine("NU exista medici inregistrati, lista e goala ");
                return;
            }

            Console.WriteLine("Alegeti criteriul dupa care vreti sa efectuati cautarea");
            Part[] TipCriteriu = (Part[])Enum.GetValues(typeof(Part));

            for (int i = 0; i < TipCriteriu.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, TipCriteriu[i]);
            }

            Console.WriteLine("Introducti varianta dorita: ");
            int choice;
            do
            {
                Int32.TryParse(Console.ReadLine(), out choice);
            } while (!Enum.IsDefined(typeof(Part), choice));

            Enum.TryParse(choice.ToString(), out Part res);

            switch (res)
            {
                case Part.E_ID:
                    if (!MedicSearchByID())
                    {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu acest ID");
                    }
                    break;
                case Part.E_PRENUME:
                    if (!MedicSearchByPrenume())
                    {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu acest Prenume");
                    }
                    break;
                case Part.E_NUME:
                    if (!MedicSearchByNume())
                    {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu acest Nume");
                    }
                    break;
                case Part.E_AGE:
                    if (!MedicSearchByAge())
                    {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu aceasta Varsta");
                    }
                    break;
                case Part.E_GEN:
                    if (!MedicSearchByGen())
                    {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu acest Gen");
                    }
                    break;
                case Part.E_NRTELEFON:
                    if (!MedicSearchByNrTelefon())
                    {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu acest Numar de Telefon");
                    }
                    break;
                case Part.E_SPECIALIZARE:
                    if (!MedicSearchBySpecializare())
                    {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu aceasta Specializare");
                    }
                    break;
                default:
                    Console.WriteLine("Nu cunoastem acest criteriu ");
                    break;
            }
        }

        public bool MedicSearchByID()
        {
            Console.WriteLine("Alegeti ID pe care vreti sa il cautati");
            Int32.TryParse(Console.ReadLine(), out int _ID);
            bool exists = false;

            foreach (var medic in MediciList)
            {
                if (_ID == medic.GetID)
                {
                    Console.WriteLine(medic.InfoPers());
                    exists = true;
                }
            }
            return exists;
        }

        public bool MedicSearchByPrenume()
        {
            Console.WriteLine("Alegeti Prenume  pe care vreti sa il cautati");
            string _Prenume = Console.ReadLine();
            bool exists = false;

            foreach (var medic in MediciList)
            {
                if (_Prenume.Equals(medic.Prenume, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(medic.InfoPers());
                    exists = true;
                }
            }
            return exists;
        }
        public bool AlreadyExists(Medic medCmp)
        {
            
            if (MediciList.Count == 0)
            {
                return false;
            }
            foreach (var med in MediciList)
            {
                if (med.GetID == medCmp.GetID)
                {
                    return true;
                }

            }
            return false;
        }

        public bool MedicSearchByNume()
        {
            Console.WriteLine("Alegeti Numele pe care vreti sa il cautati");
            string _Nume = Console.ReadLine();
            bool exists = false;

            foreach (var medic in MediciList)
            {
                if (_Nume.Equals(medic.Nume, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(medic.InfoPers());
                    exists = true;
                }
            }
            return exists;
        }

        public bool MedicSearchByAge()
        {
            Console.WriteLine("Alegeti Varsta pe care vreti sa o cautati");
            Int32.TryParse(Console.ReadLine(), out int _Age);
            bool exists = false;

            foreach (var medic in MediciList)
            {
                if (_Age == medic.age)
                {
                    Console.WriteLine(medic.InfoPers());
                    exists = true;
                }
            }
            return exists;
        }

        public bool MedicSearchByGen()
        {
            Console.WriteLine("Alegeti Genul pe care vreti sa il cautati (M/F)");
            char _Gen = Console.ReadLine()[0];
            bool exists = false;

            foreach (var medic in MediciList)
            {
                if (char.ToUpper(_Gen) == char.ToUpper(medic.Gen))
                {
                    Console.WriteLine(medic.InfoPers());
                    exists = true;
                }
            }
            return exists;
        }

        public bool MedicSearchByNrTelefon()
        {
            Console.WriteLine("Alegeti Numărul de telefon pe care vreti sa il cautati");
            string _NrTelefon = Console.ReadLine();
            bool exists = false;

            foreach (var medic in MediciList)
            {
                if (_NrTelefon == medic.nrTelefon)
                {
                    Console.WriteLine(medic.InfoPers());
                    exists = true;
                }
            }
            return exists;
        }

        public bool MedicSearchBySpecializare()
        {
            Console.WriteLine("Alegeti Specializarea pe care vreti sa o cautati");
            string _Specializare;
            int i = 0;

            DoctorType[] Types = (DoctorType[])Enum.GetValues(typeof(DoctorType));
            foreach (DoctorType type in Types)
            {
                Console.WriteLine("{0}.{1}", i, type);
                i++;
            }

            do
            {
                _Specializare = string.Empty;
                Int32.TryParse(Console.ReadLine(), out int MedType);

                if (Enum.IsDefined(typeof(DoctorType), MedType))
                {
                    Enum.TryParse(MedType.ToString(), out DoctorType res);
                    _Specializare = res.ToString();
                }
                else
                {
                    Console.WriteLine("Introduceti o varianta valabila\n");
                }
            } while (_Specializare == string.Empty);

            bool exists = false;

            foreach (var medic in MediciList)
            {
                if (_Specializare.Equals(medic.GetSpecializare, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(medic.InfoPers());
                    exists = true;
                }
            }
            return exists;
        }
    }
}