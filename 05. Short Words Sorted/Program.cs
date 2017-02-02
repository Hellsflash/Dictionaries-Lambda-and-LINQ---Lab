using System;
using System.Linq;

namespace _05.Short_Words_Sorted
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(
                ", ", Console.ReadLine()
                .ToLower()
                .Split(
                new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' },
                 StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList()));


        }
    }
}
