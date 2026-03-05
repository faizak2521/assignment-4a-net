// Hourly worker subclass that inherits from the Employee class
using System;

public class HourlyWorker : Employee
{
    // data members
    private float hoursworked;
    private float payrate;

    // default constructor
    public HourlyWorker() : base()
    {
        hoursworked = 0;
        payrate = 0;
    }

    // set-all constructor
    public HourlyWorker(int id, string firstName, string lastName, float hoursworked, float payrate) : base(id, firstName, lastName)
    {
        this.hoursworked = hoursworked;
        this.payrate = payrate;
    }

    // setData method
    public void setData(int id, string firstName, string lastName, float hoursworked, float payrate)
    {
        base.setData(id, firstName, lastName);
        this.hoursworked = hoursworked;
        this.payrate = payrate;
    }

    // setters
    public void setHoursworked(float hoursworked)
    {
        this.hoursworked = hoursworked;
    }

    public void setPayrate(float payrate)
    {
        this.payrate = payrate;
    }

    // getters
    public float getHoursworked()
    {
        return hoursworked;
    }

    public float getPayrate()
    {
        return payrate;
    }

    // displayData piggybacking base class
    public new string displayData()
    {
        return base.displayData() + " " + hoursworked + " " + payrate;
    }

    // override earnings
    public override string earnings()
    {
        float weeklyPay;

        if (hoursworked <= 40)
        {
            weeklyPay = hoursworked * payrate;
        }
        else
        {
            float regularPay = 40 * payrate;
            float overtimePay = (hoursworked - 40) * payrate * 1.5f;
            weeklyPay = regularPay + overtimePay;
        }

        return "HourlyWorker " + base.getId() + " " + base.getFirstName() + " " + base.getLastName() + " " + weeklyPay;
    }
}
