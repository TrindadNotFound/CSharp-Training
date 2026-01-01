// See https://aka.ms/new-console-template for more information

using S4_TriangleArea.entities;

Console.WriteLine("Enter the retangle height and width : ");
Console.Write("Width : ");
double width = double.Parse(Console.ReadLine());
Console.Write("Height : ");
double height = double.Parse(Console.ReadLine());

Retangle retangle = new Retangle(width, height);

Console.WriteLine();
Console.WriteLine($"Area : {retangle.Area()}");
Console.WriteLine($"Perimeter : {retangle.Perimeter()}");
Console.WriteLine($"Diagonal : {retangle.Diagonal()}");