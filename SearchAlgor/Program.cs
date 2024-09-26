using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgor
{
    internal class Program
    {
        static Random randomGenerator = new Random();
       
        static void Main(string[] args)
        {
            List<double> listOfDoubles = new List<double>();
            List<string> listOfNames = new List<string> { "Carrie", "Bob", "Kelly", "Phil", "Sam", "Pauline", "Killian" };

            PrintNameList(listOfNames);
            RequestNameSearch(listOfNames);
            

            PopulateListWithRandomDoubles(ref listOfDoubles, 10);
            PrintList(listOfDoubles);

            RequestSearch(listOfDoubles);
            

            Console.ReadKey();
        }

        static void RequestSearch(List<double> list) 
        {
            Double searchValue;
            Console.WriteLine(" What value would you like to search for? ");

            if (Double.TryParse(Console.ReadLine(), out searchValue))
            {
                //int index = LinearSearch.Perform(searchValue, list);
                int index = BinarySearch.Perform(searchValue, list);
                if (index < 0)
                {
                    Console.WriteLine(" Not Found ");
                }
                else
                {
                    Console.WriteLine("Found at: " + index);
                }
            }
        }

        static void RequestNameSearch(List<string> list)
        {
            string searchName;
            Console.WriteLine(" What name would you like to search for? ");
            searchName = Console.ReadLine();

                int index = LinearSearch.Perform(searchName, list);
                //int index = BinarySearch.Perform(searchValue, list);
                if (index < 0)
                {
                    Console.WriteLine(" Not Found ");
                }
                else
                {
                    Console.WriteLine("Found at: " + index);
                }
            
        }

        static void PopulateListWithRandomDoubles(ref List<double> list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                double twoDigitDouble = Double.Parse(randomGenerator.NextDouble().ToString("0.0000"));
                list.Add(twoDigitDouble);
            }
            
            list.Sort();
        }

        static void PrintList(List<double> list) 
        {
            Console.WriteLine("\n\nList Print: \n");

            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine("  " + list[i].ToString());
            }

            Console.WriteLine("\nEnd \n");
        
        }
        static void PrintNameList(List<string> list)
        {
            Console.WriteLine("\n\nList Print: \n");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("  " + list[i].ToString());
            }

            Console.WriteLine("\nEnd \n");

        }
    }
}
