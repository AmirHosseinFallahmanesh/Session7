using System;

namespace Part3
{
    class Program
    {
        delegate int Calculator(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine(Operation(min, 12, 16));
        }
        static int sum(int a, int b) => a + b;
        static int min(int a, int b) => a - b;
        static int mul(int a, int b) => a * b;
        static int div(int a, int b) => a / b;
        static int Operation(Calculator calculator,int number1,int number2)
        {
          return  calculator.Invoke(number1, number2);
        }

    }
}
