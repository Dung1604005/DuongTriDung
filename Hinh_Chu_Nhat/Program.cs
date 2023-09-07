public class Programm{
    static void Main(string[] args)
    {
        Rectangle rec = new Rectangle(5, 10);
        Console.WriteLine(rec.GetArea());
        Console.WriteLine(rec.GetPerimeter());
        
        rec.Display();
    }
}