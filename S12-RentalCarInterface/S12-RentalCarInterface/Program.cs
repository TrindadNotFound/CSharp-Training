
using System.Globalization;
using S12_RentalCarInterface.entities;

Console.WriteLine("Car data :");

Console.Write("Car model: ");
string carModel = Console.ReadLine();

Console.Write("Pickup (dd/mm/yyyy):" );
DateTime pickupDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new DateTimeFormatInfo());

Console.Write("Return date (dd/mm/yyyy):" );
DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new DateTimeFormatInfo());

CarRental carRental = new CarRental(pickupDate, returnDate, new Vehicle(carModel));