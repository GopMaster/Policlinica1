using System;
using AdministrareMedici;

using System.Collections.Generic;
using System.Text.RegularExpressions;
using Policlinica;


namespace Program
{
    public class Program
    {

        static void Main(string[] args)
        {
            NivelDeStocareMedic meds = new NivelDeStocareMedic();
            AdministrareMediciFisier AdminMedic = new AdministrareMediciFisier(AdministrareMediciFisier.fileName);
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
            Console.WriteLine("Introduceti Specializarea medicului");
            string _specializ = Console.ReadLine();
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



    }
}
