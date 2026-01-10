// See https://aka.ms/new-console-template for more information

using S10_ExceptionsExample.entities;
using S10_ExceptionsExample.entities.exceptions;

try
{


    Console.WriteLine("Hotel reservation data :");
    Console.Write("Room number : ");
    int roomNumber = int.Parse(Console.ReadLine());

    Console.Write("CheckIn date : ");
    DateTime checkInDate = DateTime.Parse(Console.ReadLine());

    Console.Write("CheckOut date : ");
    DateTime checkOutDate = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(roomNumber, checkInDate, checkOutDate);

    Console.WriteLine();

    Console.WriteLine($"First reservation date : {reservation}");

    Console.WriteLine();

    Console.Write("New CheckIn date : ");
    DateTime newCheckInDate = DateTime.Parse(Console.ReadLine());

    Console.Write("New CheckOut date : ");
    DateTime newCheckOutDate = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(newCheckInDate, newCheckOutDate);

    Console.WriteLine();

    Console.Write($"Last reservation date : {reservation}");
}
catch (DomainException ex)
{
    Console.WriteLine(ex.Message);
}