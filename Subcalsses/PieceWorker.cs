// Piece worker subclass that inherits from the Employee class

using System;

public class PieceWorker : Employee
{
    // data members
    private float wage_per_piece;
    private int quantity;

    // default constructor
    public PieceWorker() : base()
    {
        wage_per_piece = 0;
        quantity = 0;
    }

    // set-all constructor
    public PieceWorker(int id, string firstName, string lastName, float wagePerPiece, int quantity) : base(id, firstName, lastName)
    {
        this.wage_per_piece = wagePerPiece;
        this.quantity = quantity;
    }

    // setData method
    public void setData(int id, string firstName, string lastName, float wagePerPiece, int quantity)
    {
        base.setData(id, firstName, lastName);
        this.wage_per_piece = wagePerPiece;
        this.quantity = quantity;
    }

    // setters
    public void setWagePerPiece(float wagePerPiece)
    {
        this.wage_per_piece = wagePerPiece;
    }

    public void setQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    // getters
    public float getWagePerPiece()
    {
        return wage_per_piece;
    }

    public int getQuantity()
    {
        return quantity;
    }

    // displayData piggybacking base class
    public new string displayData()
    {
        return base.displayData() + " " + wage_per_piece + " " + quantity;
    }

    // override earnings
    public override string earnings()
    {
        float weeklyPay = wage_per_piece * quantity;

        return "Piece Worker " + base.getId() + " " + base.getFirstName() + " " + base.getLastName() + " " + weeklyPay;
    }
}
