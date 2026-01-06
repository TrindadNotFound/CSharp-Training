using S8_OrderItems.entities.enums;

namespace S8_OrderItems.entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Items { get; set; }
    public Client Client { get; set; }

    public Order(DateTime moment, OrderStatus status, List<OrderItem> items, Client client)
    {
        Moment = moment;
        Status = status;
        Items = items;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        double sum = 0;
        foreach (OrderItem i in Items)
        {
            sum += i.Quantity * i.Price;
        }
        return sum;
    }
}