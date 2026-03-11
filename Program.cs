// Faiza Khan
// March 2, 2026

// Employee class 

using System;

// NEW: 4B
using System.IO;
using System.Collections.Generic;

public class Employee
{
    // Data members
    private int id_num;
    private string first_name;
    private string last_name;

    // Default constructor
    public Employee()
    {
        id_num = 0;
        first_name = "No Name";
        last_name = "No Name";
    }

    // Set-all constructor
    public Employee(int id, string firstName, string lastName)
    {
        id_num = id;
        first_name = firstName;
        last_name = lastName;
    }

    // setData method
    public void setData(int id, string firstName, string lastName)
    {
        id_num = id;
        first_name = firstName;
        last_name = lastName;
    }

    // Optional overload if no data is provided
    public void setData()
    {
        id_num = 0;
        first_name = "No Name";
        last_name = "No Name";
    }

    // Setters
    public void setId(int id)
    {
        id_num = id;
    }

    public void setFirstName(string firstName)
    {
        first_name = firstName;
    }

    public void setLastName(string lastName)
    {
        last_name = lastName;
    }

    // Getters
    public int getId()
    {
        return id_num;
    }

    public string getFirstName()
    {
        return first_name;
    }

    public string getLastName()
    {
        return last_name;
    }

    // displayData method
    public string displayData()
    {
        return id_num + " " + first_name + " " + last_name;
    }

    // Virtual earnings method
    public virtual string earnings()
    {
        return "0";
    }
}

// Test driver class
public class Program
{
    public static void Main(string[] args)
    {
        // NEW: 4B - create a list to hold all employees
        List<Employee> employees = new List<Employee>();

        string[] lines = File.ReadAllLines("/Users/faiza/Documents/NET/assignment4a/employee.txt");

        // NEW: 4B - read each line, parse the data, create the appropriate employee object, and add it to the list
        foreach (string line in lines)
        {
            string[] parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries); // split on any whitespace (spaces or tabs)

            // This all indicates the type of employee and the order of data in the file that must mathc the expected order for each employee type (S, H, C, P)
            char type = parts[0][0];
            int id = int.Parse(parts[1]);
            string first = parts[2];
            string last = parts[3];

            Employee emp = null; // will hold the employee object we create based on the type

            switch (type)
            {
                // NOTE: The order of the data in the file must match the expected order for each employee type
                case 'S':
                    float salary = float.Parse(parts[4]);
                    emp = new SalaryWorker();
                    ((SalaryWorker)emp).setData(id, first, last, salary);
                    break;

                case 'H':   
                    float hours = float.Parse(parts[4]);
                    float rate = float.Parse(parts[5]);
                    emp = new HourlyWorker();
                    ((HourlyWorker)emp).setData(id, first, last, hours, rate);
                    break;

                case 'C':
                    float baseSalary = float.Parse(parts[4]);
                    float commission = float.Parse(parts[5]);
                    float sales = float.Parse(parts[6]);
                    emp = new CommissionWorker();
                    ((CommissionWorker)emp).setData(id, first, last, baseSalary, commission, sales);
                    break;

                case 'P':
                    float wage = float.Parse(parts[4]);
                    int qty = int.Parse(parts[5]);
                    emp = new PieceWorker();
                    ((PieceWorker)emp).setData(id, first, last, wage, qty);
                    break;
            }

            employees.Add(emp); // add the created employee to the list
        }

        // NEW: 4B - display the report header and then loop through the list to display each employee's data and earnings
        Console.WriteLine("Gross-pay salary report");
        Console.WriteLine("{0,-25}{1,-15}{2,-15}{3,-15}{4,-15}", "Employee Type", "Emp Number", "First", "Last", "Weekly Pay");

        foreach (Employee e in employees)
        {
            Console.WriteLine("{0,-25}{1,-15}{2,-15}{3,-15}{4,-15}", e.GetType().Name.Replace("Worker"," Worker"), e.getId(), e.getFirstName(), e.getLastName() , e.earnings().Split(' ')[5]); // Extract the weekly pay from the earnings string
        }


        /* Original test code (commented out since we're now reading from the file) */
        // Console.WriteLine("Testing Data");
        // Console.WriteLine(new string('=', 67));
        // Console.WriteLine();

        // // Employee_1: Salary Worker (S)
        // SalaryWorker employee1 = new SalaryWorker();
        // employee1.setData(123, "Martha", "Perez", 56785.59f);

        // Console.WriteLine("Employee_1:");
        // Console.WriteLine("Salary Worker (S)");
        // Console.WriteLine("ID\tLast\t\tFirst\t\tYearly Salary");
        // Console.WriteLine($"{employee1.getId()}\t{employee1.getLastName()}\t{employee1.getFirstName()}\t\t{employee1.getSalary()}");
        // Console.WriteLine("displayData():  " + employee1.displayData());
        // Console.WriteLine("earnings():     " + employee1.earnings());
        // Console.WriteLine();

        // // Employee_2: Hourly Worker (H)
        // HourlyWorker employee2 = new HourlyWorker();
        // // NOTE: Our setData() signature is (id, first, last, hoursworked, payrate)
        // employee2.setData(435, "Joe", "Smith", 42.5f, 18.67f);

        // Console.WriteLine("Employee_2:");
        // Console.WriteLine("Hourly Worker (H)");
        // Console.WriteLine("ID\tLast\t\tFirst\t\tRate\t\tHours");
        // Console.WriteLine($"{employee2.getId()}\t{employee2.getLastName()}\t{employee2.getFirstName()}\t\t{employee2.getPayrate()}\t{employee2.getHoursworked()}");
        // Console.WriteLine("displayData():  " + employee2.displayData());
        // Console.WriteLine("earnings():     " + employee2.earnings());
        // Console.WriteLine();

        // // Employee_3: Commission Worker (C)
        // CommissionWorker employee3 = new CommissionWorker();
        // employee3.setData(356, "Anthony", "Mendez", 30563.56f, 0.003f, 57864.53f);

        // Console.WriteLine("Employee_3:");
        // Console.WriteLine("Commission Worker (C)");
        // Console.WriteLine("ID\tLast\t\tFirst\t\tYearly-Salary\tCommission-Rate\tWeek-Sales");
        // Console.WriteLine($"{employee3.getId()}\t{employee3.getLastName()}\t{employee3.getFirstName()}\t\t{employee3.getSalary()}\t\t{employee3.getCommRate()}\t\t{employee3.getSales()}");
        // Console.WriteLine("displayData():  " + employee3.displayData());
        // Console.WriteLine("earnings():     " + employee3.earnings());
        // Console.WriteLine();

        // // Employee_4: Piece Worker (P)
        // PieceWorker employee4 = new PieceWorker();
        // employee4.setData(452, "Jimmy", "James", 0.50f, 1201);

        // Console.WriteLine("Employee_4:");
        // Console.WriteLine("Piece Worker (P)");
        // Console.WriteLine("ID\tLast\tFirst\t\tWage-Per-Piece\tQuantity");
        // Console.WriteLine($"{employee4.getId()}\t{employee4.getLastName()}\t{employee4.getFirstName()}\t\t{employee4.getWagePerPiece()}\t\t{employee4.getQuantity()}");
        // Console.WriteLine("displayData():  " + employee4.displayData());
        // Console.WriteLine("earnings():     " + employee4.earnings());
        // Console.WriteLine();
    }
    
}
