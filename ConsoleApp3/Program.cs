
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Employee
{
    public Employee(int id, string name, int age, decimal salary, int hrId, double bonus)
    {
        Id = id;
        Name = name;
        Age = age;
        Salary = salary;
        HrId = hrId;
        Bounus = bonus;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public int HrId { get; set; }
    public double Bounus { get; set; }
    public bool IsDeleted { get; set; } = false; // Assuming employee is not deleted by default
    public DateTime CreatedOn { get; set; } = DateTime.Now;

    // Method to print employee data
    public void Print()
    {
        if (!IsDeleted)
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary:C}, HR ID: {HrId}, Bonus: {Bounus}, Created On: {CreatedOn}");
        }
        else
        {
            Console.WriteLine($"Employee {Id} has been deleted and cannot be printed.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter number of Employees: ");
        int empNumber = int.Parse(Console.ReadLine());

        Employee[] employeeArray = new Employee[empNumber];

        // Collecting employee data
        for (int i = 0; i < employeeArray.Length; i++)
        {
            Console.WriteLine($"\nEnter details for Employee {i + 1}:");

            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter HR ID: ");
            int hrId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Bonus: ");
            double bonus = double.Parse(Console.ReadLine());


            employeeArray[i] = new Employee(id, name, age, salary, hrId, bonus);
        }


        Console.WriteLine("\nEmployee Details:");
        foreach (var emp in employeeArray)
        {
            emp.Print();
        }

        #region task 
        int[] originalArray = { 1, 2, 3, 4, 5 };
        int[] copyArray = new int[8];


        Array.Copy(originalArray, copyArray, originalArray.Length);
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.WriteLine(copyArray[i]);
        }

        Console.WriteLine("\nLength of copyArray: " + copyArray.Length);
        for (int i = originalArray.Length; i < copyArray.Length; i++)
        {
            Console.WriteLine($"Enter value for index {i}:");
            copyArray[i] = int.Parse(Console.ReadLine());
        }

        #endregion
    }
}   