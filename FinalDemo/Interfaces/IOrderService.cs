using ConsoleApp4.Models;

namespace ConsoleApp4.Interfaces;

public interface IOrderService
{
    Order CreateOrder(Order order);
    Order AddProductToOrder (int orderId, Product product);
    Order RemoveProductToOrder(int orderId, int productId);
    Order ConfirmOrder(Order order);
    Order CancelOrder (Order order);
    Order GetOrder (int orderId);
    List<Order> GetCustomerOrders (int customerId);
}
