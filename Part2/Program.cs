using System;

namespace Part2
{
    class Program
    {
        delegate void operation(int a, int b);
        static void Main(string[] args)
        {
            operation operation = sum;
            operation += min;
            operation += mul;
            operation += div;
            operation.Invoke(4, 2);
        }

        static void sum(int a,int b) => Console.WriteLine(a+b);
        static void min(int a,int b) => Console.WriteLine(a-b);
        static void mul(int a,int b) => Console.WriteLine(a*b);
        static void div(int a,int b) => Console.WriteLine(a/b);

    }
}
