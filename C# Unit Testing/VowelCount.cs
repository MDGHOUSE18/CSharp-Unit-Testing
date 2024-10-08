using System;
using System.Collections.Generic;
using System.Text;

namespace C__Unit_Testing
{
    public class VowelCount
    {
        public int CountVowels(string str)
        {
            if (str == null)return 0;
            int count = 0;
            foreach (char c in str.ToLower())
            {
                if (c=='a'|| c=='e' || c=='i' || c=='o' || c=='u') count++;
            }
            return count;
        }
    }
}
