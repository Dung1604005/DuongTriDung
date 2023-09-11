public class Program{
    static void Main(string[] args)
    {
        Circle circle = new Circle(0.3);
        circle.Resize(0.2);
        Console.WriteLine(circle.GetRadius());
    }
}