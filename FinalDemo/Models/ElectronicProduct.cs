namespace ConsoleApp4.Models;

public class ElectronicProduct : Product
{
    public string Brand { get; set; }
    public int WarrantyMonths { get; set; }
    public ElectronicProduct(int ıd, string name, string description, decimal price, string category, int stock, bool ısDeleted, DateTime ısCreated, string brand, int warrantyMonths) 
        : base(ıd, name, description, price, category, stock, ısDeleted, ısCreated)
    {
        Brand = brand;
        WarrantyMonths = warrantyMonths;
    }
    public override void GetProductInfo()
    {
        base.GetProductInfo();
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Warranty: {WarrantyMonths}");
    }
}
