using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Newsletter
    {
        private bool _isSigned;
        public bool IsSigned
        { get => _isSigned;
            set
            { 
         if (_isSigned == true)
            { SignIn(); }
         else
            { UnSign(); }
            }
        }
         public void SignIn()
        { Console.WriteLine("Prawda"); }
        public void UnSign()
        {
         Console.WriteLine("Fałsz");
        }
    }  
}
