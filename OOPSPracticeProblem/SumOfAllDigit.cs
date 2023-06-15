using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPSPracticeProblem
{
    public class SumOfAllDigit
    {
        public void SumOfNumber()
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while(num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }

            Console.WriteLine("Sum of all Digit is: "+sum);

        }
    }
}
