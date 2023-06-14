using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeProblem
{
    public class FrequencyCount
    {
        public void FrequencyCounts()
        {

            int[] array = {10,20,30,10,20,10};

            Array.Sort(array);

            for(int i = 0; i < array.Length - 1; i++)
            {
                int count = 1;
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine("Element: "+array[i]+" with frequency: "+count);
                }
            }
        }
    }
}
