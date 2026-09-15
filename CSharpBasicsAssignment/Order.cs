namespace CSharpBasicsAssignment;

public class Order
{
    // 10 Concrete Fields
    public int OrderId;
    public string CustomerName = string.Empty;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity = string.Empty;
    public char Priority;
    public long ItemCode;

    // Method 1: Calculate Total
    public void CalculateTotal()
    {
        TotalPrice = Quantity * UnitPrice * (decimal)(1 - (DiscountPercent / 100));
    }

    // Method 2: Print Summary
    public void PrintSummary()
    {
        Console.WriteLine($"Order #{OrderId} | Customer: {CustomerName} | Total: {TotalPrice:C} | Paid: {IsPaid}");
    }
}