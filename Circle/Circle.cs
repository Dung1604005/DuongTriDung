public abstract class Circle{
    public double rad;
    public string color;
    public Circle(double rad, string color){
        this.rad = rad;
        this.color = color;

    }
    public abstract void ToString();
}
public class Cylinder: Circle{
    double height;

    public Cylinder(double rad, string color, double height) : base(rad, color)
    {
        this.height = height;
    }
    public override void ToString()
    {
        Console.WriteLine($"rad: {rad}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Height: {height}");
    }

}