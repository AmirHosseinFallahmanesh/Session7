using System;
//delegate
namespace Part1
{
    class Program
    {
        delegate void MD();
        delegate string MD2(int a, int b);
        static void Main(string[] args)
        {

            MD md = Print;
            MD2 md2 = sum;
            md2.Invoke(12, 14);
            md2(12, 16);

            //md();
            md.Invoke();
        }

        static void Print()
        {
            Console.WriteLine("Print SomeThing");
        }

        static string sum(int n1,int n2)
        {
            return (n1 + n2).ToString();
        }
    }
}
