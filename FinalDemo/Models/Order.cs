namespace ConsoleApp4.Models;

public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; } = null!;
    public List<Product> Items { get; set; } = new();
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public bool TryRemoveFromStock(Product product, int quantity, out decimal totalPrice)
    {
        totalPrice = 0;
        if (product.Stock < quantity)
            return false;

        product.Stock -= quantity;
        totalPrice = product.Price * quantity;
        return true;
    }
    public void ApplyDiscount (ref decimal price, decimal percentage)
    {
        price = price - (price * percentage / 100);
    }


}
