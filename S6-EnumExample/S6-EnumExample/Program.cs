// See https://aka.ms/new-console-template for more information

using S6_EnumExample.entities;
using S6_EnumExample.entities.enums;

Order order = new Order
{
    Id = 1,
    Moment = DateTime.Now,
    Status = OrderStatus.Processing
};

Console.WriteLine(order); //Print order object

//Convert OrderStatus value to String
Console.WriteLine(OrderStatus.Delivered.ToString()); 
Console.WriteLine(Enum.Parse<OrderStatus>("Shipped"));
