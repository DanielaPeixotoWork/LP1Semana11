using System;
using System.Collections.Generic;
using System.Linq;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            return items.OfType<T>().Count();
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            var items = new List<object>
            {
                1, 2, 3, "string1", "string2", 4.5, 6.7, new DateTime(2023, 1, 1), new DateTime(2024, 1, 1)
            };

            int intCount = Checker.HowManyOfType<int>(items);
            int stringCount = Checker.HowManyOfType<string>(items);
            int doubleCount = Checker.HowManyOfType<double>(items);
            int dateTimeCount = Checker.HowManyOfType<DateTime>(items);

            Console.WriteLine($"Number of int items: {intCount}");
            Console.WriteLine($"Number of string items: {stringCount}");
            Console.WriteLine($"Number of double items: {doubleCount}");
            Console.WriteLine($"Number of DateTime items: {dateTimeCount}");

            Console.WriteLine("Merci d’utiliser ce programme!");
        }
    }
}
