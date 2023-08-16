public class Program{
    static void Main(string[] args)
    {
        const int rate = 23000;
        float usd ;
        usd = float.Parse(Console.ReadLine());
        float vnd = usd*rate;
        Console.WriteLine(usd + "USD = " + vnd + "VND");
    }
}