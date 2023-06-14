using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeProblem
{
    public class UniqueElement
    {
        public void IsUnique()
        {
            int[] arr1 = { 1, 2, 3, 2, 3, 5, 6, 2 };
            Console.WriteLine("Unique Elements in array are: ");

            for (int i = 0; i < arr1.Length; i++)
            {
                bool flag = false;
                for(int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}
