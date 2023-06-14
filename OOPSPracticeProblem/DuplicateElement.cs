using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSPracticeProblem
{
    public class DuplicateElement
    {
        public int count = 0;
        public void IsDuplicate()
        {
            int[] arr = {1,2,3,2,3,5,6,2};


            for(int i  = 0; i < arr.Length; i++) 
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                        count++;
                    }
                }
            }
            Console.WriteLine("Duplicate Number of elemts are: " + count);
        }
    }
}
