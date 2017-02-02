using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var counts = new SortedDictionary<double, int>();

            
            foreach (var number in listOfNumbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }

            foreach (var numbers in counts)
            {
                Console.WriteLine($"{numbers.Key} -> {numbers.Value}");
            }
        }
    }
}
