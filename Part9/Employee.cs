namespace Part9
{
    class Employee
    {
        public Employee(int id, string fullName, int age, double salary,bool active)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Salary = salary;
            Active = active;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return FullName + " age= " + Age + " salary= " + Salary;
        }
    }
}
