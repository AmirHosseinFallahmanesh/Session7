using System;
using System.Collections.Generic;

namespace Part6
{
    class Program
    {
        delegate bool condition(int value);
        static List<int> numbers = new List<int>() { 12, 20, 41, 15, 16 };
        static void Main(string[] args)
        {
            var list = filters((a)=> a<40 && a>15);
            var list1 = filters1((a)=> a<40 && a>15);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }


        static List<int> filters1(Func<int,bool> pr)
        {
            List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (pr(item))
                {
                    result.Add(item);
                }
            }
            return result;
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
