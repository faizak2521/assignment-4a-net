// Faiza Khan
// March 2, 2026

// Employee class 

using System;
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
        Console.WriteLine("Testing Data");
        Console.WriteLine(new string('=', 67));
        Console.WriteLine();

        // Employee_1: Salary Worker (S)
        SalaryWorker employee1 = new SalaryWorker();
        employee1.setData(123, "Martha", "Perez", 56785.59f);

        Console.WriteLine("Employee_1:");
        Console.WriteLine("Salary Worker (S)");
        Console.WriteLine("ID\tLast\t\tFirst\t\tYearly Salary");
        Console.WriteLine($"{employee1.getId()}\t{employee1.getLastName()}\t{employee1.getFirstName()}\t\t{employee1.getSalary()}");
        Console.WriteLine("displayData():  " + employee1.displayData());
        Console.WriteLine("earnings():     " + employee1.earnings());
        Console.WriteLine();

        // Employee_2: Hourly Worker (H)
        HourlyWorker employee2 = new HourlyWorker();
        // NOTE: Our setData() signature is (id, first, last, hoursworked, payrate)
        employee2.setData(435, "Joe", "Smith", 42.5f, 18.67f);

        Console.WriteLine("Employee_2:");
        Console.WriteLine("Hourly Worker (H)");
        Console.WriteLine("ID\tLast\t\tFirst\t\tRate\t\tHours");
        Console.WriteLine($"{employee2.getId()}\t{employee2.getLastName()}\t{employee2.getFirstName()}\t\t{employee2.getPayrate()}\t{employee2.getHoursworked()}");
        Console.WriteLine("displayData():  " + employee2.displayData());
        Console.WriteLine("earnings():     " + employee2.earnings());
        Console.WriteLine();

        // Employee_3: Commission Worker (C)
        CommissionWorker employee3 = new CommissionWorker();
        employee3.setData(356, "Anthony", "Mendez", 30563.56f, 0.003f, 57864.53f);

        Console.WriteLine("Employee_3:");
        Console.WriteLine("Commission Worker (C)");
        Console.WriteLine("ID\tLast\t\tFirst\t\tYearly-Salary\tCommission-Rate\tWeek-Sales");
        Console.WriteLine($"{employee3.getId()}\t{employee3.getLastName()}\t{employee3.getFirstName()}\t\t{employee3.getSalary()}\t\t{employee3.getCommRate()}\t\t{employee3.getSales()}");
        Console.WriteLine("displayData():  " + employee3.displayData());
        Console.WriteLine("earnings():     " + employee3.earnings());
        Console.WriteLine();

        // Employee_4: Piece Worker (P)
        PieceWorker employee4 = new PieceWorker();
        employee4.setData(452, "Jimmy", "James", 0.50f, 1201);

        Console.WriteLine("Employee_4:");
        Console.WriteLine("Piece Worker (P)");
        Console.WriteLine("ID\tLast\tFirst\t\tWage-Per-Piece\tQuantity");
        Console.WriteLine($"{employee4.getId()}\t{employee4.getLastName()}\t{employee4.getFirstName()}\t\t{employee4.getWagePerPiece()}\t\t{employee4.getQuantity()}");
        Console.WriteLine("displayData():  " + employee4.displayData());
        Console.WriteLine("earnings():     " + employee4.earnings());
        Console.WriteLine();
    }
}
