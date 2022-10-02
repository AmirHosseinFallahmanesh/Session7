using System;

namespace Part5
{
    class Program
    {
        delegate void vnp();
        delegate void vp(string name);
        delegate string rnp();
        delegate string rp(string a1,string a2);
        static void Main(string[] args)
        {
            vnp vnp1 = new vnp(delegate () {
                Console.WriteLine("Welcome To My App");
                Console.WriteLine("This is test");
            });


            vnp vnp2 = new vnp(() =>
            {
                Console.WriteLine("Welcome To My App");
                Console.WriteLine("This is test");

            });

            vnp vnp3 = () =>
            {
                Console.WriteLine("Welcome To My App");
                Console.WriteLine("This is test");

            };



            vp vp1 = new vp(delegate (string name)
              {
                  Console.WriteLine("Welcome To My App "+name);
              });




            vp vp2 = new vp((name) =>
              {
                  Console.WriteLine("Welcome To My App " + name);
              });


            vp vp3 = (name) =>
            {
                Console.WriteLine("Welcome To My App " + name);
            };


            vp vp4 = (name) => Console.WriteLine("Welcome To My App " + name);
           

            rnp rnp1 = new rnp(delegate ()
              {
                  return "Hello ";
              });


            rnp rnp2 = new rnp( ()=>
            {
                return "Hello ";
            });

            rnp rnp3 = () =>
            {
                return "Hello ";
            };

            rnp rnp4 = () => "Hello ";
            
                
            

            rp rp1 = new rp(delegate (string name, string surname)
              {
                  return "hello " + name + " " + surname;
              });

            rp rp2 = new rp( ( name,  surname)=>
            {
                return "hello " + name + " " + surname;
            });

            rp rp3 = (name, surname) =>
            {
                return "hello " + name + " " + surname;
            };

            rp rp4 = (name, surname) => "hello " + name + " " + surname;
           
        }
    }
}
