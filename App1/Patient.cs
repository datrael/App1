using System;
using System.Collections.Generic;
using System.Text;

public enum PatientType
{
    Regular,
    New
}
namespace App1
{
    class Patient
    {
        public string PatientType {get; set; }
        public string Name{ get; set;}
        public Adress Adress { get; set; }

        public Newsletter Newsletter { get; set; }
        public void Display()
        {
            Console.WriteLine("Pacjent o nazwie: " + Name + " posiada adres: " + Adress +  " Czy jest zapisany na newsletter? " + Newsletter);
        }
    }
}
