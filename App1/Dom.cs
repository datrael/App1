using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Dom
    {
       private int number;
       public int Number 
       {
            get
            {return number;}
            set
            {
                if (value > 20 && value < 40)
                { number = value; }
                else
                { 
                    throw new Exception(message:"Przepełnione"); 
                }
            }
       }
       public string Option { get; set; }
       public string Name { get; set; }
    }
}
