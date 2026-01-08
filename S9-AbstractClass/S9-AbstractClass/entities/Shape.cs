using S9_AbstractClass.entities.enums;

namespace S9_AbstractClass.entities;

public abstract class Shape
{
    public Color Color { get; }
    
    public Shape (Color color)
    {
        Color = color;
    }

    public abstract double Area();
}