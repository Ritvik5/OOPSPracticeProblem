using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeProblem
{
    public class ReverseEachWord
    {
        public void Reverse()
        {
            string str;
            string reverseString = "";
            Console.WriteLine("Enter the String: ");
            str = Console.ReadLine();

            str = str.ToLower();

            for(int i =str.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + str[i];
            }

            Console.WriteLine("Reverse string is: " + reverseString); 
        }
    }
}
