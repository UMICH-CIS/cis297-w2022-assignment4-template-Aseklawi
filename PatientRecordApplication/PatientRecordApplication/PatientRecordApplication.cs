using System;
using System.IO;

namespace ConsoleApp
{
    class Patient
    {
        private int id;
        private string name;
        private double balance;
        public Patient(int id, string name, double balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public void wirteToFile()
        {
            using (StreamWriter w = File.AppendText("Patients.txt"))
            {
                w.WriteLine("ID : " + this.id + ", Name : " + this.name + ", Balance " + this.balance, w);
            }
        }
    }
}