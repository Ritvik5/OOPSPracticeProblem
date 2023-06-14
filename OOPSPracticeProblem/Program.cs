namespace OOPSPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object Oriented Practice Problem!!!\n");

            //-- Duplicate Elements
            //DuplicateElement element = new DuplicateElement();
            //element.IsDuplicate();

            //--Unique Elements

            //UniqueElement unique = new UniqueElement();
            //unique.IsUnique();

            //--Frequency count
            //FrequencyCount freq = new FrequencyCount();
            //freq.FrequencyCounts();
            
            //--MaximumMinimumElement
            MaxMinElements maxMin = new MaxMinElements();
            maxMin.MaximumElement();
            maxMin.MinimumElement();
        }
    }
}