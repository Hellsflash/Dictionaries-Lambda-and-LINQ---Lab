using System;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
 
        }
    }
}
