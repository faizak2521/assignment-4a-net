// Salary worker subclass that inherits from the Employee class
using System;

public class SalaryWorker : Employee
{
    // data member
    private float salary;

    // default constructor
    public SalaryWorker() : base()
    {
        salary = 0;
    }

    // set-all constructor
    public SalaryWorker(int id, string firstName, string lastName, float salary) : base(id, firstName, lastName)
    {
        this.salary = salary;
    }

    // setData method
    public void setData(int id, string firstName, string lastName, float salary)
    {
        base.setData(id, firstName, lastName);
        this.salary = salary;
    }

    // setter
    public void setSalary(float salary)
    {
        this.salary = salary;
    }

    // getter
    public float getSalary()
    {
        return salary;
    }

    // displayData piggybacking base class
    public new string displayData()
    {
        return base.displayData() + " " + salary;
    }

    // override earnings
    public override string earnings()
    {
        float weeklyPay = salary / 52;

        return "Salary Worker " + base.getId() + " " + base.getFirstName() + " " + base.getLastName() + " " + weeklyPay;
    }
}
