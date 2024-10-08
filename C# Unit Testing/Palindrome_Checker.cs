using System;
using System.Collections.Generic;
using System.Text;

namespace C__Unit_Testing
{
    /*
     * Palindrome Checker
        Scenario: Write a method that checks if a string is a palindrome.
        Practice Tests:
        Test with a simple palindrome: "madam" should return true.
        Test with a non-palindrome: "hello" should return false.
        Test with a single character: "A" should return true.
        Test with mixed case letters: "RaceCar" should return true (ignoring case).
        Test with a phrase palindrome: "A man a plan a canal Panama" (ignoring spaces).
     */
    public class Palindrome_Checker
    {
        public bool CheckingPolindrome(string input)
        {
            if (input.Length == 0)
            {
                return true;
            }
            //input = input.ToLower();
            char[] charArray = input.Replace(" ","").ToLower().ToCharArray();
            int first=0, last=charArray.Length-1;

            while (first<last)
            {
                if (charArray[first] != charArray[last])
                {
                    return false;
                }
                first++;
                last--;
            }
            return true;
        }
    }
}
