using System;

namespace SortByProperty_Reflection
{
    public class Company
    {
        public string Name { get; set; }

        public int EmployeesNumber { get; set; }

        public Company()
        {
            Name = Program.RandomStringGenerate(10);
            EmployeesNumber = new Random().Next(100000);
        }
    }
}
