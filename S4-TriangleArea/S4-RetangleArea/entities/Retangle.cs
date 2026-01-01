namespace S4_TriangleArea.entities;

public class Retangle
{
    private double width;
    private double height;

    public Retangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    
    public double Width
    {
        get => width;
        set => width = value;
    }
    
    public double Height
    {
        get => height;
        set => height = value;
    }

    public double Area()
    {
        return width * height;
    }

    public double Perimeter()
    {
        return (height * 2) + (width * 2);
    }

    public double Diagonal()
    {
        return Math.Sqrt(width * width + height * height);
    }
}