namespace ConsoleApp4.Models;

public class ClothingProduct : Product
{
    public int Size { get; set; }
    public string Material { get; set; }
    public string Gender { get; set; }
    public ClothingProduct(int ıd, string name, string description, decimal price, string category, int stock, bool ısDeleted, DateTime ısCreated, int size, string material, string gender)
        : base(ıd, name, description, price, category, stock, ısDeleted, ısCreated)
    {
        Size = size;
        Material = material;
        Gender = gender;
    }
    public override void GetProductInfo()
    {
        base.GetProductInfo();
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Material: {Material}");
        Console.WriteLine($"Gender: {Gender}");
    }
}
