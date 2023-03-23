using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhoneClass;

namespace PhoneDatabase
{
    public class AdministrareTelefon_txt
    {
        
        
        private string numeFisier = "Telefon.txt";

        public AdministrareTelefon_txt(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddTelefon(Phone phone)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
               if (phone.GetIdTelef() != 0)
                {
                    streamWriterFisierText.WriteLine(phone.ConversieLaSir_PentruFisier());
                }
            }
        }


        public Phone[] GetTelefoane(int nrTelefoane)
        {
            Phone[] telefoane = new Phone[nrTelefoane];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrTelefoane = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    telefoane[nrTelefoane++] = new Phone(linieFisier);
                }
            }

            return telefoane;
        }

    }
}
