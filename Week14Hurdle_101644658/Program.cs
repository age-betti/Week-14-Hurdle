using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortSearchLibrary;

namespace Week14Hurdle_101644658
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read CSV
            List<int> numbers = CSVReader.ReadCSV(@"H:\Other\Uni\Diploma\Semester 1\Programming\Week 14 - NeedToComplete\unsorted_numbers.csv");

            //Timer
            DateTime start;
            DateTime end;

            //SORTING
      
            //Insert
            start = System.DateTime.Now;
            List<int> insertionSorted = InsertionSort.Sort(numbers);
            end = System.DateTime.Now;
            TimeSpan insertionTime = end - start;

            //Shell
            start = System.DateTime.Now;
            List<int> shellSorted = ShellSort.Sort(numbers);
            end = System.DateTime.Now;
            TimeSpan shellTime = end - start;

            //Times
            Console.WriteLine("Sorting times:");
            Console.WriteLine($"Insertion sorted in: { insertionTime.TotalSeconds} seconds");
            Console.WriteLine($"Shell sorted in: { shellTime.TotalSeconds} seconds");

            //SEARCHING

            //Numbers to Search
            int[] numSearch = new int[]
            {
                insertionSorted[0],
                insertionSorted[1500],
                insertionSorted[3000],
                insertionSorted[4500],
                insertionSorted[6000],
                insertionSorted[7500],
                insertionSorted[9000],
                insertionSorted[10500],
                insertionSorted[12000],
                insertionSorted[13500],
                insertionSorted.Last(),
            };

            //Linear
            Console.WriteLine("\nLinear searching:");
            start = System.DateTime.Now;
            foreach (int number in numSearch)
            {
                int? LinearPosition = LinearSearch.Search(insertionSorted, number);
                Console.WriteLine($"number {number} found at position {LinearPosition}");
            }
            end = System.DateTime.Now;
            TimeSpan linearSortedTime = end - start;
            Console.WriteLine($"Linear search time in seconds: {linearSortedTime.TotalSeconds}");

            //Binary
            Console.WriteLine("\nBinary searching:");
            start = System.DateTime.Now;
            foreach (int number in numSearch)
            {
                int? BinaryPosition = Binary.Search(insertionSorted, number);
                Console.WriteLine($"number {number} found at position {BinaryPosition}");
            }
            end = System.DateTime.Now;
            TimeSpan binaryTime = end - start;
            Console.WriteLine($"Binary search time seconds: {binaryTime.TotalSeconds}");
        }
    }
}
