// Commission worker subclass that inherits from the Employee class

using System;

public class CommissionWorker : Employee
{
    // data members
    private float salary;
    private float comm_rate;
    private float sales;

    // default constructor
    public CommissionWorker() : base()
    {
        salary = 0;
        comm_rate = 0;
        sales = 0;
    }

    // set-all constructor
    public CommissionWorker(int id, string firstName, string lastName, float salary, float commRate, float sales) : base(id, firstName, lastName)
    {
        this.salary = salary;
        this.comm_rate = commRate;
        this.sales = sales;
    }

    // setData method
    public void setData(int id, string firstName, string lastName, float salary, float commRate, float sales)
    {
        base.setData(id, firstName, lastName);
        this.salary = salary;
        this.comm_rate = commRate;
        this.sales = sales;
    }

    // setters
    public void setSalary(float salary)
    {
        this.salary = salary;
    }

    public void setCommRate(float commRate)
    {
        this.comm_rate = commRate;
    }

    public void setSales(float sales)
    {
        this.sales = sales;
    }

    // getters
    public float getSalary()
    {
        return salary;
    }

    public float getCommRate()
    {
        return comm_rate;
    }

    public float getSales()
    {
        return sales;
    }

    // displayData piggybacking base class
    public new string displayData()
    {
        return base.displayData() + " " + salary + " " + comm_rate + " " + sales;
    }

    // override earnings
    public override string earnings()
    {
        float weeklyPay = (sales * comm_rate) + (salary / 52);

        return "Commission Worker " + base.getId() + " " + base.getFirstName() + " " + base.getLastName() + " " + weeklyPay;
    }
}
