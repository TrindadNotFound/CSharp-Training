
using S9_AbstractClass.entities;
using S9_AbstractClass.entities.enums;

Console.Write("Enter the number of shapes : ");
int numberOfShapes = int.Parse(Console.ReadLine());

List<Shape> shapeList = new List<Shape>();

for (int i = 1; i <= numberOfShapes; i++)
{
    Console.WriteLine("Shape #{0} data : ");
    
    Console.Write("Rectangle or Circle (r/c) : ");
    char shape = char.Parse(Console.ReadLine());
    
    Console.Write("Color (BLACK/BLUE/RED/GREEN) : ");
    Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

    if (shape == 'R' || shape == 'r')
    {
        Console.Write("Width : ");
        double width = double.Parse(Console.ReadLine());
    
        Console.Write("Height : ");
        double height = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height, color);
        shapeList.Add(rectangle);

    } else if (shape == 'C' || shape == 'c')
    {
        Console.Write("Radius : ");
        double radius = double.Parse(Console.ReadLine());

        Circle circle = new Circle(radius, color);
        shapeList.Add(circle);
    }
}

Console.WriteLine("");
Console.WriteLine("SHAPE AREAS");
foreach (Shape shape in shapeList)
{
    Console.WriteLine(shape.Area());
}