using System;
using AdministrareMedici;

using System.Collections.Generic;
using System.Text.RegularExpressions;
using Policlinica;
using System.Security.Cryptography.X509Certificates;


namespace Program
{
    public class Program
    {

        static void Main(string[] args)
        {

           
           
                AdministrareMediciFisier AdminMedic = new AdministrareMediciFisier();
            if (args.Length == 0)
            {
                AdminMedic.SetFileName(FisierConfigurari.GetFileNameConf());
                Console.WriteLine("Nu avem argumente in linia de comanda");
                
            }
            else {
                Console.WriteLine("Datele se vor pastra si vor fi citite din fisierul {0}\n", args[0]);
                AdminMedic.SetFileName(args[0]);
                
            }
            NivelDeStocareMedic meds = new NivelDeStocareMedic();
            Medic temp_medic = new Medic();
            char CHR;
            while (true)
            {

                Console.Clear();
                MENU();
                CHR = Console.ReadKey().KeyChar;
                switch (CHR)
                {

                    case '1':
                        temp_medic = CitireMedicTastatura();
                        meds.AddMedic(temp_medic);
                        break;
                    case '2':
                        AfisareInfoMedic(temp_medic);
                        break;
                    case '3':
                        AdminMedic.AddMedicToFile(temp_medic);
                        break;
                    case '4':
                        meds.SetMedics(AdminMedic.GetMedicsFromFile(out meds.nrMedici));
                        break;
                    case '5':
                        AfisareMedici(meds);
                        break;
                    case '6':
                        meds.FindMedic();
                        break;

                    default:
                        Console.WriteLine("Nu se cunoaste operatia");
                        break;


                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(); // Pauses the console until any key is pressed

            
            }


        }
        public static bool FunctieValidareText(string sample, string RegexValidation)
        {
            if (string.IsNullOrEmpty(sample)) return false;
            return Regex.IsMatch(sample, RegexValidation);

        }
        public static void MENU()
        {
            Console.WriteLine("1.Citire medicului de la tastatură");
            Console.WriteLine("2. Afisarea informatiilor despre ultimului medic introdus");
            Console.WriteLine("3. Adauga medic in fisier");
            Console.WriteLine("4.Citeste medici din fisier");
            Console.WriteLine("5.Afisare medici");
            Console.WriteLine("6.Cautare Medic din lista curenta");



        }
        public static Medic CitireMedicTastatura()
        {


            Console.WriteLine("Introduceti Numele medicului: ");
            string nume;
            do
            {
                nume = Console.ReadLine();
            } while (FunctieValidareText(nume, @"^[A-Za-z]+$") == false);

            Console.WriteLine("Introduceti Prenumele medicului: ");
            string prenume;
            do
            {
                prenume = Console.ReadLine();
            } while (FunctieValidareText(prenume, @"^[A-Za-z]+$") == false);

            Console.WriteLine("Introduceti Varsta medicului: ");
            string varsta;
            do
            {
                varsta = Console.ReadLine();
            } while (FunctieValidareText(varsta, @"^(120|1[01][0-9]|[1-9]?[0-9])$") == false);

            Console.WriteLine("Introduceti Genul medicului: M - Masculin F - Feminin");
            char gen;
            bool isValid = false;
            do
            {
                gen = Console.ReadLine()[0];
                if (gen == 'F' || gen == 'M')
                {
                    isValid = true;
                }
                else
                    isValid = false;
            } while (isValid == false);

            Console.WriteLine("Introduceti Emailul  medicului: ");
            string email;
            do
            {
                email = Console.ReadLine();
            } while (FunctieValidareText(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") == false);

            Console.WriteLine("Introduceti NrTelefon al  medicului: ");
            string nrTelefon;
            do
            {
                nrTelefon = Console.ReadLine();
            } while (FunctieValidareText(nrTelefon, @"^(072|073|074|075|076|077|078)\d{7}$") == false);
            Int32.TryParse(varsta, out int age);
            string _specializ = string.Empty;
                Console.Clear();
                Console.WriteLine("Introduceti Specializarea medicului");
                PrintSpecializare();
            do
            {
                _specializ = string.Empty;
                
                Int32.TryParse(Console.ReadLine(), out int MedType);
                if (Enum.IsDefined(typeof(DoctorType), MedType))
                {
                    Enum.TryParse((MedType).ToString(), out DoctorType res);
                    _specializ = res.ToString();
                }
                else {
                    Console.WriteLine("Introduceti o varianta valabila\n");
                }

            } while (_specializ == string.Empty);
            
           
            return new Medic(nume, prenume, age, gen, nrTelefon, email, _specializ);

        }
        
        public static void AfisareInfoMedic(Medic med)
        {
            Console.WriteLine(med.InfoPers());
        }

        public static void AfisareMedici(NivelDeStocareMedic listamedici)
        {
            for (int i = 0; i < listamedici.nrMedici; i++)
            {
                Console.WriteLine(listamedici.Medici[i].InfoPers());
            }

        }
        public static void PrintSpecializare() {
            DoctorType[] doctortypes = (DoctorType[])Enum.GetValues(typeof(DoctorType));
            int i = 0;
            foreach (DoctorType doctor in doctortypes) {
                Console.WriteLine("{0}.{1}",i,doctor);
                i++;
            }
        }



    }
}
