using System;
using System.Linq;

namespace _06.Fold_and_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            var upperLeft = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var upperRight = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var upper = upperLeft
                .Concat(upperRight)
                .ToArray();
            var lower = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var sum = upper
                .Select((x, index) => x + lower[index])
                .ToArray();

            foreach (var item in sum)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
         }
    }
}
