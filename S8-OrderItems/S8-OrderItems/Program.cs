
using S8_OrderItems.entities;
using S8_OrderItems.entities.enums;

Console.WriteLine("Enter client data : ");
Console.Write("Name : ");
string clientName = Console.ReadLine();

Console.Write("Email : ");
string clientEmail = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY) : ");
DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(clientName, clientEmail, clientBirthDate);

Console.WriteLine("");

Console.WriteLine("Enter order data : ");
Console.Write("Status : ");
OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order ? ");
int numberOfItems = int.Parse(Console.ReadLine());

Order order = new Order(DateTime.Now, orderStatus, client);

Console.WriteLine("");

for (int i = 1; i <= numberOfItems; i++)
{
    Console.WriteLine($"Enter #{i} item data");
    Console.Write("Product name : ");
    string productName = Console.ReadLine();
    Console.Write("Product price : ");
    double productPrice = double.Parse(Console.ReadLine());
    Console.Write("Quantity : ");
    int productQuantity = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    Product product = new Product(productName, productPrice);
    OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
    order.AddItem(orderItem);
}

