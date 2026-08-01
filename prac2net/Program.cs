using System;

interface IPayroll
{
    void CalculateSalary();
}

class Employee : IPayroll
{
    public int id;
    public string name;
    public double basicSalary;

    public Employee(int i, string n, double s)
    {
        id = i;
        name = n;
        basicSalary = s;
    }

    public void CalculateSalary()
    {
        double hra = basicSalary * 0.20;
        double da = basicSalary * 0.10;
        double gross = basicSalary + hra + da;

        Console.WriteLine("Employee ID : " + id);
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("Basic Salary : " + basicSalary);
        Console.WriteLine("HRA : " + hra);
        Console.WriteLine("DA : " + da);
        Console.WriteLine("Gross Salary : " + gross);
    }
}

class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int i, string n, double s) : base(i, n, s) { }
}

class PartTimeEmployee : Employee
{
    public PartTimeEmployee(int i, string n, double s) : base(i, n, s) { }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n1. Full Time Employee");
        Console.WriteLine("2. Part Time Employee");
        Console.Write("Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            FullTimeEmployee f = new FullTimeEmployee(id, name, salary);
            f.CalculateSalary();
        }
        else if (choice == 2)
        {
            PartTimeEmployee p = new PartTimeEmployee(id, name, salary);
            p.CalculateSalary();
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }

        Console.ReadLine();
    }
}