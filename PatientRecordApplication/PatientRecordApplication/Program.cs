using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecordApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double balance;


            Console.Write("Patient ID : ");
            id = int.Parse(Console.ReadLine());


            Console.Write("Patient Name : ");
            name = Console.ReadLine();


            Console.Write("Patient Balance : ");
            balance = double.Parse(Console.ReadLine());


            Patient p = new Patient(id, name, balance);
            p.wirteToFile();


            Console.WriteLine("Record has been added to file.");
            Console.ReadKey();
        }
    }
}


