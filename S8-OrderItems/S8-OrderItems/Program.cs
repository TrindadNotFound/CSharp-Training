
using S8_OrderItems.entities;

Console.WriteLine("Enter client data : ");
Console.Write("Name : ");
string clientName = Console.ReadLine();

Console.Write("Email : ");
string clientEmail = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY) : ");
DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(clientName, clientEmail, clientBirthDate);

Console.WriteLine("");

Console.WriteLine("Enter client data : ");

