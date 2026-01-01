// See https://aka.ms/new-console-template for more information

using S4_CalculateOldestPerson.entities;

Console.WriteLine("First person data :");
Console.Write("Name -> ");
string firstPersonName = Console.ReadLine();
Console.Write("Age -> ");
int firstPersonAge = int.Parse(Console.ReadLine());

Person firstPersonData = new Person(firstPersonName, firstPersonAge);

Console.WriteLine();

Console.WriteLine("Second person data :");
Console.Write("Name -> ");
string secondPersonName = Console.ReadLine();
Console.Write("Age -> ");
int secondPersonAge = int.Parse(Console.ReadLine());

Person secondPersonData = new Person(secondPersonName, secondPersonAge);

Console.WriteLine();
if (firstPersonData.Age > secondPersonData.Age)
{
    Console.WriteLine($"{firstPersonData.Name} is older than {secondPersonData.Name}");
}
else
{
    Console.WriteLine($"{secondPersonData.Name} is older than {firstPersonData.Name}");
}