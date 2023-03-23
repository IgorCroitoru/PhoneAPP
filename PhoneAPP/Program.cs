using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PhoneDatabase;
using PhoneClass;
using System.Configuration;

namespace PhoneAPP
{
    class Program
    {
        static void Main()
        {
            Phone phone = new Phone();
            string numeFisier = "Telefon.txt";
            AdministrareTelefon_txt adminTelefon = new AdministrareTelefon_txt(numeFisier);
            int nrTelef = File.ReadAllLines(numeFisier).Length;

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii dispozitiv");
                Console.WriteLine("A. Afisare telefoane");
                Console.WriteLine("F. Afisare telefonae din fisier");
                Console.WriteLine("S. Salvare telefon in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("C. Cauta telefon");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        int idTelef = nrTelef + 1;
                        // Phone phone = new Phone();
                        Console.WriteLine("INTRODU DATE TELEFON #{0}\n", idTelef);
                        Console.WriteLine("BRAND: ");
                        phone.Brand = Console.ReadLine();
                        Console.WriteLine("MODEL: ");
                        phone.Model = Console.ReadLine();
                        Console.WriteLine("SISTEMA DE OPERARE: ");
                        phone.Os = Console.ReadLine();
                        Console.WriteLine("PRET(LEI): ");
                        phone.Price = float.Parse(Console.ReadLine());
                        Console.WriteLine("DIMENSIUNE DISPLAY(INCH): ");
                        phone.ScreenSize = float.Parse(Console.ReadLine());
                        Console.WriteLine("CAPACITATEA BATERIEI(mAh): ");
                        phone.BatteryCapacity = int.Parse(Console.ReadLine());
                        Console.WriteLine("CALITATEA CAMEREI FRONTALE(Mpx): ");
                        phone.CameraQuality = int.Parse(Console.ReadLine());
                        Console.WriteLine("RAM(GB): ");
                        phone.Ram = int.Parse(Console.ReadLine());
                        Console.WriteLine("MEMORIA INTERNA(GB): ");
                        phone.StorageCapacity = int.Parse(Console.ReadLine());
                        Console.WriteLine("GREUTATE(grame): ");
                        phone.Weight = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tip SIM(Double SIM/Single SIM): ");
                        phone.Sim = Console.ReadLine();
                        Console.WriteLine("Retea(introduceti un numar intreg 5->5G,4->4G): ");
                        phone.Network = int.Parse(Console.ReadLine());
                        Console.WriteLine("ANUL LANSARII: ");
                        phone.year = int.Parse(Console.ReadLine());
                        Console.WriteLine("CULOAREA: ");
                        phone.color = Console.ReadLine();
                        Console.WriteLine("NUCLEI PROCESOR: ");
                        phone.Cores = int.Parse(Console.ReadLine());
                        nrTelef++;
                        phone.idTelefon = idTelef;
                        //Console.WriteLine(phone);
                        //adminTelefon.AddTelefon(phone);
                        break;
                    //case "A":
                    //    string infoStudent = student.Info();
                    //    Console.WriteLine("Studentul {0}", infoStudent);

                    //    break;
                    case "F":
                        Phone[] telefoane = adminTelefon.GetTelefoane(nrTelef);
                        foreach(Phone telefon in telefoane)
                        {
                            Console.WriteLine(telefon);
                        }

                        break;
                    case "S":
                        adminTelefon.AddTelefon(phone);
                        //adaugare student in fisier
                        //adminTelefon.AddTelefon(phone);
                        break;
                    //case "C":
                    //    Console.WriteLine($"Introdu numele studentului");
                    //    nume = Console.ReadLine();
                    //    Console.WriteLine($"Introdu prenume studentului");
                    //    prenume = Console.ReadLine();
                    //    var cautatul = adminStudenti.FindStudent(nume, prenume);
                    //    if (cautatul != null)
                    //    {
                    //        Console.WriteLine($"Studentul {cautatul.GetPrenume()} {cautatul.GetNume()} cu id-ul #{cautatul.GetIdStudent()} a fost gasit");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Studentul nu a fost gasit");
                    //    }


                       // break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
    }
}
