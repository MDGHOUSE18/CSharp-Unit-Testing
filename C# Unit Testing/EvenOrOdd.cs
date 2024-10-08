using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Unit_Testing
{
    public class EvenOrOdd
    {
        public bool Even(int num) { 
            return num% 2 == 0;
        }
        public bool Odd(int num)
        {
            return num% 2 != 0;
        }
    }
}
