using System.Text;
using S8_OrderItems.entities.enums;

namespace S8_OrderItems.entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Items { get; set; }  = new List<OrderItem>();
    public Client Client { get; set; }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
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

    public override string ToString()
    {
        double sum = 0;
        StringBuilder stBuilder = new StringBuilder();
        stBuilder.AppendLine("------ SUMMARY ------");
        stBuilder.AppendLine($"Order moment : {Moment.ToString("dd/MM/yyyy  HH:mm:ss")}");
        stBuilder.AppendLine($"Order status : {Status}");
        stBuilder.AppendLine($"Client : {Client.Name}");
        stBuilder.AppendLine("--------------------");
        stBuilder.AppendLine($"--- Order items ---");
        foreach (OrderItem i in Items)
        {
            stBuilder.AppendLine(i.ToString());
            sum += i.SubTotal();
        }
        stBuilder.AppendLine("");
        stBuilder.AppendLine($"Total value : {sum.ToString("F2")}");
        
        return stBuilder.ToString();
    }
}