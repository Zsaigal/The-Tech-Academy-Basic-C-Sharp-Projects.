using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>() 
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id=2, FirstName="Joe", LastName="Fat"},
                new Employee { Id = 3, FirstName = "Thomas", LastName = "Edison" },
                new Employee { Id = 4, FirstName = "Nikola", LastName = "Tesla" },
                new Employee { Id = 5, FirstName = "Albert", LastName = "Einstein" },
                new Employee { Id = 6, FirstName = "Isaac", LastName = "Newton" },
                new Employee { Id = 7, FirstName = "Galileo", LastName = "Galilei" },
                new Employee { Id = 8, FirstName = "Rosalind", LastName = "Frankil" },
                new Employee { Id = 9, FirstName = "Michael", LastName = "Faraday" },
                new Employee { Id = 10, FirstName = "Friedrich", LastName = "Nietzsche" },
            };



            List<Employee> joes = employeesList.Where(employee=>employee.FirstName=="Joe").ToList();

            Console.WriteLine("Employees with firstname Joe:");
            foreach (var joe in joes)
            {
                Console.WriteLine("Id: " + joe.Id + ",Name: " + joe.FirstName + " " + joe.LastName);
            }

            List<Employee> Idmorethan5 = employeesList.Where(employees => employees.Id > 5).ToList();
            
            Console.WriteLine("List with Id more than 5:");
            foreach (var emp in Idmorethan5)
            {
                Console.WriteLine("Id: " + emp.Id + ",Name: " + emp.FirstName + " " + emp.LastName);
            }

        }
    }
}
