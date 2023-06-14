using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeProblem
{
    public class MaxMinElements
    {
        public int[] array2 = { 10, 9, 25, 35, 95, 90, 32 };
        public void MaximumElement()
        {
            int max = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] > max)
                {
                    max = array2[i];
                }
            }
            Console.WriteLine("Maximum Element in Array is: "+max);
        }

        public void MinimumElement()
        {
            int min = array2[0];

            for(int i = 0; i < array2.Length;i++)
            {
                if (array2[i] < min)
                {
                    min = array2[i];
                }
            }
            Console.WriteLine("Minimum Element in Array is: "+min);
        }
    }
}
