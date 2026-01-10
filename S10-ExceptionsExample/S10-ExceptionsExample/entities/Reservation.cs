namespace S10_ExceptionsExample.entities;
using S10_ExceptionsExample.entities.exceptions;

public class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    
    public Reservation(int  roomNumber, DateTime checkIn, DateTime checkOut)
    {
        CheckException(checkIn, checkOut);
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {
        return (CheckOut - CheckIn).Days;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        CheckException(checkIn, checkOut);
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    private void CheckException(DateTime checkIn, DateTime checkOut)
    {
        DateTime dateNow = DateTime.Now;
        
        if (checkIn < dateNow.Date || checkOut < dateNow.Date)
        {
            throw new DomainException("CheckIn/CheckOut date is invalid");            
        }

        if (checkOut <= checkIn)
        {
            throw new DomainException("CheckIn date can't be before CheckOut date");
        }
    }
    public override string ToString()
    {
        return $"Room : {RoomNumber} - CheckIn : {CheckIn.ToString("dd/MM/yyyy")} - CheckOut : {CheckOut.ToString("dd/MM/yyyy")} - Duration : {Duration()}";
    }
}