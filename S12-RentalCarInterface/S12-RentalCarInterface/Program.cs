
using System.Globalization;
using S12_RentalCarInterface.entities;
using S12_RentalCarInterface.services;

Console.WriteLine("-- Car data --");

Console.Write("Car model: ");
string carModel = Console.ReadLine();

Console.Write("Pickup (dd/mm/yyyy HH:mm): " );
DateTime pickupDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new DateTimeFormatInfo());

Console.Write("Return date (dd/mm/yyyy HH:mm): " );
DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new DateTimeFormatInfo());

CarRental carRental = new CarRental(pickupDate, returnDate, new Vehicle(carModel));

Console.WriteLine();

Console.Write("Enter price per hour: ");
double pricePerhour = double.Parse(Console.ReadLine());

Console.Write("Enter price per day: ");
double pricePerDay = double.Parse(Console.ReadLine());

RentalService rentalService = new RentalService(pricePerhour, pricePerDay, new USTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine();

Console.WriteLine(" -- INVOICE -- ");
Console.WriteLine(carRental.Invoice);