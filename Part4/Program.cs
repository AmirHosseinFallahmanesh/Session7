using System;
using System.Collections.Generic;

namespace Part4
{
    class Program
    {
        delegate bool condition(int value);
        static List<int> numbers = new List<int>() { 12, 20, 41, 15, 16 };
        static void Main(string[] args)
        {
           var list= filters(checkUpperThan18);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static bool checkLowerThan18(int value)
        {
            return value < 18;
        }

        static bool checkUpperThan18(int value)
        {
            return value > 18;
        }

        static List<int> filters(condition condition)
        {
            List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
