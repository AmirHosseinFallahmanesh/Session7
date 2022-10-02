using System;

namespace Part7
{
    class Program
    {
        //delegate void   action
        //delegate return  function
        static void Main(string[] args)
        {

            //delegate void (int,int)
            Action<int, int> ac = (a, b) => Console.WriteLine(a+b);

            //delegate void (string,string,int)
            Action<string, string, int> ac1 = (name, surname, age) =>
              {
                  Console.WriteLine($"Hi I am {name} {surname} I am {age}");
              };
            //ac1.Invoke("amir", "amiri", 18);


            //delegate string()
            Func<string> fn1 = () => "test";

            //delagate string(string)
            Func<string, string> fn2 = (name) =>
            {
                return "Hello " + name;
            };


            //delagate string(int,int)
            Func<int,int, string> fn3 = (n1,n2) =>
            {
                return (n1 + n2).ToString(); ;
            };

            Console.WriteLine(fn3.Invoke(2,4));
        }
    }
}
