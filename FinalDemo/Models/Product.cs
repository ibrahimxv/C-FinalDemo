namespace ConsoleApp4.Models;

public class Product
{
    public Product(int ıd, string name, string description, decimal price, string category, int stock, bool ısDeleted, DateTime ısCreated)
    {
        Id = ıd;
        Name = name;
        Description = description;
        Price = price;
        Category = category;
        Stock = stock;
        IsDeleted = ısDeleted;
        IsCreated = ısCreated;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime IsCreated { get; set; }

    public virtual void GetProductInfo()
    {
        Console.WriteLine("Product info:");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Stock: {Stock}");
        Console.WriteLine($"IsDeleted: {IsDeleted}");
        Console.WriteLine($"Created: {IsCreated:yyyy-MM-dd HH:mm:ss}");
    }
    public decimal CalculateDiscount(decimal discountPercent)
    {
        return Price - (Price * discountPercent / 100);
    }
}
