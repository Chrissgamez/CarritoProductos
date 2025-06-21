namespace OrdersService.Models;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public DateTime OrderDate { get; set; }
}
public class OrderItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}