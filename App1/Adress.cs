using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Adress
    {
        public Adress()
        { }
        public string _city;
        public string _street;
        public string FullAdress => $"{_city}, ul. {_street}";
        private void PrepareAdress()
        { Console.WriteLine(FullAdress); }
    }  
}   


