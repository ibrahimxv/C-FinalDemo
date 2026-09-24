using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Models;

public class OrderService : IOrderService
{
    public Order AddProductToOrder(int orderId, Product product)
    {
        throw new NotImplementedException();
    }

    public Order CancelOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Order ConfirmOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Order CreateOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public List<Order> GetCustomerOrders(int customerId)
    {
        throw new NotImplementedException();
    }

    public Order GetOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public Order RemoveProductToOrder(int orderId, int productId)
    {
        throw new NotImplementedException();
    }
}
