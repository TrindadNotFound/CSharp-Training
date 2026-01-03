// See https://aka.ms/new-console-template for more information

Console.Write("How many rooms you want rent ? ");
int numberOfRooms = int.Parse(Console.ReadLine());

Guests[] roomsForRent = new Guests[numberOfRooms];

Console.WriteLine();

for (int i = 0; i < roomsForRent.Length; i++)
{
    Console.WriteLine($"Room #{i}");
    Console.Write("Name : ");
    string name = Console.ReadLine();

    Console.Write("Email : ");
    string email = Console.ReadLine();

    Console.Write("Room : ");
    int room = int.Parse(Console.ReadLine());

    Console.WriteLine();

    roomsForRent[i] = new Guests(name, email, room);
}

Console.WriteLine("Busy rooms : ");
for (int i = 0; i < roomsForRent.Length; i++)
{
    Console.WriteLine(roomsForRent[i]);
}