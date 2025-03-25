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
        public void  FindMedic( ) {
            if (nrMedici == 0) {
                Console.WriteLine("NU exista medici inregistrati, lista e goala ");
                return;
            }
            Console.WriteLine("Alegeti criteriul dupa care vreti sa efectuati cautarea");
            Part[] TipCriteriu  = (Part[])Enum.GetValues(typeof(Part));
            int i = 0;
            foreach ( Part criteriu in TipCriteriu) {

                Console.WriteLine("{0}. {1}",i, criteriu);
                i++;
            }
            Console.WriteLine("Introducti varianta dorita: ");
            do
            {
                Int32.TryParse(Console.ReadLine(), out  i);
            }while( !Enum.IsDefined(typeof(Part), i));
            Enum.TryParse((i).ToString(), out Part res);
            switch (res)
            {

                case Part.E_ID:
                 
                    if (!MedicSearchByID()) {
                        Console.WriteLine("Nu sa putut gasi nici un Medic cu acest ID");
                    }
                    break;
                case Part.E_PRENUME:
                    if (MedicSearchByPrenume()) { 
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
        public bool MedicSearchByID(  ) {
           

            Console.WriteLine("Alegeti ID pe care vreti sa il cautati");
            Int32.TryParse(Console.ReadLine(), out int _ID);
            bool exists = false;

            for (int i = 0; i < nrMedici; i++) {
                if (_ID == Medici[i].GetID) {
                    Console.WriteLine(Medici[i].InfoPers());
                    exists = true;
                }
            }
            if (exists == true)
                return true;
            return false;
        }

        public bool MedicSearchByPrenume( )
        {


            Console.WriteLine("Alegeti Prenume  pe care vreti sa il cautati");
            string _Prenume = Console.ReadLine();
            bool exists = false;

            for (int i = 0; i < nrMedici; i++)
            {
                if (_Prenume == Medici[i].Prenume)
                {
                    Console.WriteLine(Medici[i].InfoPers());
                    exists = true;
                }
            }
            if (exists == true)
                return true;
            return false;
        }
        public bool MedicSearchByNume( )
        {
            Console.WriteLine("Alegeti Numele pe care vreti sa il cautati");
            string _Nume = Console.ReadLine();
            bool exists = false;

            for (int i = 0; i < nrMedici; i++)
            {
                if (_Nume == Medici[i].Nume)
                {
                    Console.WriteLine(Medici[i].InfoPers());
                    exists = true;
                }
            }
            if (exists == true)
                return true;
            return false;
        }
        public bool MedicSearchByAge( )
        {
            Console.WriteLine("Alegeti Varsta pe care vreti sa o cautati");
            Int32.TryParse(Console.ReadLine(), out int _Age);
            bool exists = false;

            for (int i = 0; i < nrMedici; i++)
            {
                if (_Age == Medici[i].age)
                {
                    Console.WriteLine(Medici[i].InfoPers());
                    exists = true;
                }
            }
            if (exists == true)
                return true;
            return false;
        }
        public bool MedicSearchByGen( )
        {
            Console.WriteLine("Alegeti Genul pe care vreti sa il cautati (M/F)");
            char _Gen = Console.ReadLine()[0]; // Simple input, no validation
            bool exists = false;

            for (int i = 0; i < nrMedici; i++)
            {
                if (char.ToUpper(_Gen) == char.ToUpper(Medici[i].Gen))
                {
                    Console.WriteLine(Medici[i].InfoPers());
                    exists = true;
                }
            }
            if (exists == true)
                return true;
            return false;
        }
        public bool MedicSearchByNrTelefon( )
        {
            Console.WriteLine("Alegeti Numărul de telefon pe care vreti sa il cautati");
            string _NrTelefon = Console.ReadLine();
            bool exists = false;

            for (int i = 0; i < nrMedici; i++)
            {
                if (_NrTelefon == Medici[i].nrTelefon)
                {
                    Console.WriteLine(Medici[i].InfoPers());
                    exists = true;
                }
            }
            if (exists == true)
                return true;
            return false;
        }
        public bool MedicSearchBySpecializare( )
        {
            Console.WriteLine("Alegeti Specializarea pe care vreti sa o cautati");
            string _Specializare;
            int i = 0;
            DoctorType[] Types = (DoctorType[])Enum.GetValues(typeof(DoctorType));
            foreach (DoctorType  type in Types)
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
                    Enum.TryParse((MedType).ToString(), out DoctorType res);
                    _Specializare = res.ToString();
                }
                else
                {
                    Console.WriteLine("Introduceti o varianta valabila\n");
                }

            } while (_Specializare == string.Empty);
            //string _Specializare = Console.ReadLine();
            bool exists = false;

            for (  i = 0; i < nrMedici; i++)
            {
                if (_Specializare.ToLower() == Medici[i].GetSpecializare.ToLower())
                {
                    Console.WriteLine(Medici[i].InfoPers());
                    exists = true;
                }
            }
            if (exists == true)
                return true;
            return false;
        }




    }
}
