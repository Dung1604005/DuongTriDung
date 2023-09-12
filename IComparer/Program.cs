public class Program{
    static void Main(string[] args)
    {
        CompareCircle cir = new CompareCircle();
        Circle c1 = new Circle(1);
        Circle c2 = new Circle(3);
        Console.WriteLine(cir.Compare(c1, c2));
    }
}