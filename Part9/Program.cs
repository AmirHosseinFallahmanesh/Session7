using System;
using System.Collections.Generic;
using System.Linq;

namespace Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"amir amiri",50,22000,true),
                new Employee(2,"sina sinaii",35,4000,false),
                new Employee(3,"mina mianii",29,3000,true),
                new Employee(4,"saman mianii",43,12000,true),
                new Employee(4,"mahya mahyaii",28,16000,false)
            };

            List<Employee> search= employees.Where(a => a.Age > 30).ToList();
            List<Employee> search1= 
                employees.Where(a => a.Age > 30 && a.Active).ToList();

            List<Employee> search2 =
         employees.Where(b => b.Salary<5000 && b.Salary>3000).ToList();

            List<Employee> search3 =
         employees.OrderBy(b => b.Salary).ToList();

            List<Employee> search4 =
       employees.OrderByDescending(b => b.Salary).ToList();


            List<Employee> search5 =
                employees.Where(a => a.Age > 30 && a.Active).OrderBy(a=>a.Salary)
                .ToList();

            
            List<Employee> search6 = employees.Take(3).ToList() ;
            List<Employee> search7 = employees.Where(a=>a.Active).Take(2).ToList() ;
            List<Employee> search8 = employees.Where(a=>a.Active).OrderBy(a=>a.Id)
                .Take(2).ToList() ;


            List<Employee> search9 = employees.Skip(2).Take(2).ToList();


            //foreach (var item in search9)
            //{
            //    Console.WriteLine(item);
            //}

            Employee employee1 = employees.First(a => a.Salary > 2000);
            //Employee employee2 = employees.First(a => a.Salary < 2000); //error
            
            
            Employee employee3 = employees.FirstOrDefault(a => a.Salary < 2000); //null

            Employee employee4 = employees.FirstOrDefault(a => a.Salary < 2000); //error


            //Employee employee5 = employees.Single(a => a.Id==20); 
            Employee employee6 = employees.SingleOrDefault(a => a.Id==20);

            //   Console.WriteLine(employee6 == null?"null": employee6.ToString());


            bool resualt = employees.All(a => a.Active); //all item pass
             resualt = employees.Any(a => a.Active); //at least 1 item pass

            int index = employees.FindIndex(a => a.Id == 2);
             index = employees.FindIndex(a => a.Age>20);
             index = employees.FindLastIndex(a => a.Age>20);
            

            Console.WriteLine(index);


            
        }
    }
}
