using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Unit_Testing
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            //checking with message
            if (message.ToLower().Contains("happy"))
            {
                return "Mood is Happy";
            }
            else
            {
                return "Mood is Sad";
            }
        }
    }
}
