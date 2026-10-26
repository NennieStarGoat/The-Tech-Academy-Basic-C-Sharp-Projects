using LambdaAssignment;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //list of ten employees
        List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Jennie", "Smith"),
                new Employee(2, "Richard", "Smith"),
                new Employee(3, "Declan", "Smith"),
                new Employee(4, "Richard", "Scott"),
                new Employee(5, "Adam", "Bangle"),
                new Employee(6, "Cian", "Denderson"),
                new Employee(7, "Edward", "Ferra"),
                new Employee(8, "George", "Harris"),
                new Employee(9, "Ian", "Jackson"),
                new Employee(10, "Kendra", "Lemon"),
            };

        //foreach loop to find dupes of Richard
        List<Employee> RichardDupes = new List<Employee>();
        foreach (var emp in employees)
        {
            if (emp.FirstName == "Richard")
            {
                RichardDupes.Add(emp);
            }
        }

        //lambda expression to find dupes of Richard
        List<Employee> RichardDupesLamb = employees.Where(emp => emp.FirstName == "Richard").ToList();

        //lambda expression to list all employees with id greater than 5
        List<Employee> IDGreaterLamb = employees.Where(emp => emp.Id > 5).ToList();

        Console.WriteLine($"Foreach count: {RichardDupes.Count}");
        Console.WriteLine($"Lambda count: {RichardDupesLamb.Count}");
        Console.WriteLine($"ID Greater than 5: {IDGreaterLamb.Count}");
    }
}