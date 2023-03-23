using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PhoneClass
{
    public class Phone
    {
        private const int ID = 0;
        private const int BRAND = 1;
        private const int MODEL = 2;
        private const int PRICE = 3;
        private const int SCREENSIZE = 4;
        private const int BATTERYCAPACITY = 5;
        private const int CAMERAQUALITY = 6;
        private const int RAM = 7;
        private const int STORAGECAPACITY = 8;
        private const int WEIGHT = 9;
        private const int SIM = 10;
        private const int OS = 11;
        private const int NETWORK = 12;
        private const int YEAR = 13;
        private const int COLOR = 14;
        private const int CORES = 15;

        public int idTelefon;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public float ScreenSize { get; set; }
        public int BatteryCapacity { get; set; }
        public int CameraQuality { get; set; }
        public int Ram { get; set; }
        public int StorageCapacity { get; set; }
        public float Weight { get; set; }
        public string Sim { get; set; }
        public string Os { get; set; }
        public int Network { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public int Cores { get; set; }

        public Phone() { }



        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\n" +
                   $"Price: {Price:C}\nScreen Size: {ScreenSize} inches\n" +
                   $"Battery Life: {BatteryCapacity} hours\nCamera Quality: {CameraQuality}Mpx\n" +
                   $"Ram: {Ram} GB\nStorage Capacity: {StorageCapacity} GB\n" +
                   $"Weight: {Weight} gr\nSim: {Sim}\n" +
                   $"Operating System: {Os}\nNetwork: {Network}G\n" +
                   $"Release year: {year}\nColor: {color}\n" +
                   $"Cores: {Cores}\n";
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}{13}{0}{14}{0}{15}{0}{16}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idTelefon.ToString(),
                (Brand.Trim() ?? "\0"),
                (Model.Trim() ?? "\0"),
                (Price.ToString() ?? "\0"),
                (ScreenSize.ToString() ?? "\0"),
                (BatteryCapacity.ToString() ?? "\0"),
                (CameraQuality.ToString() ?? "\0"),
                (Ram.ToString() ?? "\0"),
                (StorageCapacity.ToString() ?? "\0"),
                (Weight.ToString() ?? "\0"),
                (Sim.Trim() ?? "\0"),
                (Os.Trim() ?? "\0"),
                (Network.ToString() ?? "\0"),
                (year.ToString() ?? "\0"),
                (color.Trim() ?? "\0"),
                (Cores.ToString() ?? "\0"));

            return obiectPentruFisier;
        }
        public int GetIdTelef()
        {
            return idTelefon;
        }

        public Phone(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idTelefon = Convert.ToInt32(dateFisier[ID]);
            Brand = dateFisier[BRAND];
            Model = dateFisier[MODEL];
            Price = Convert.ToSingle(dateFisier[PRICE]);
            ScreenSize = Convert.ToSingle(dateFisier[SCREENSIZE]);
            BatteryCapacity = Convert.ToInt32(dateFisier[BATTERYCAPACITY]);
            CameraQuality = Convert.ToInt32(dateFisier[CAMERAQUALITY]);
            Ram = Convert.ToInt32(dateFisier[RAM]);
            StorageCapacity = Convert.ToInt32(dateFisier[STORAGECAPACITY]);
            Weight = Convert.ToSingle(dateFisier[WEIGHT]);
            Sim = dateFisier[SIM];
            Os = dateFisier[OS];
            Network = Convert.ToInt32(dateFisier[NETWORK]);
            year = Convert.ToInt32(dateFisier[YEAR]);
            color = dateFisier[COLOR];
            Cores = Convert.ToInt32(dateFisier[CORES]);



        }
        //public void AfisareTelefoane(Phone[] telefoane)
        //{
        //    foreach(Phone telefon in telefoane)
        //    {
        //        Console.Write(telefon);
        //    }
        //}
    }
}