namespace ConsoleApp4.Models;

internal class OrderItem
{
    public Product Product { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice 
    { 
        get
        {
            return Quantity * UnitPrice;
        }
    }
    public List<Product> SearchProducts(string keyword)
    {
        keyword = keyword.Trim().ToLower();
        List<Product> products = null;
        return products.Where(p =>
        p.Name.ToLower().Contains(keyword) ||
        p.Description.ToLower().Contains(keyword) ||
        p.Category.ToLower().Contains(keyword) ||
        (p is ElectronicProduct electronic &&
         electronic.Brand.ToLower().Contains(keyword))
    ).ToList();
    }
}
