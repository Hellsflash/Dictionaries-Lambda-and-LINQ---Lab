using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Min_Max_Sum_Average
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var listOfNumbers = new List<int>();
            for (int i = 1; i <= count; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                listOfNumbers.Add(numbers);
            }

            Console.WriteLine($"Sum = {listOfNumbers.Sum()}");
            Console.WriteLine($"Min = {listOfNumbers.Min()}");
            Console.WriteLine($"Max = {listOfNumbers.Max()}");
            Console.WriteLine($"Average = {listOfNumbers.Average()}");
        }
    }
}
