public class Program{
    static void Main(string[] args)
    {
        Fan fan = new Fan(3, true, "yellow", 10f);
        fan.PrintInf();
        Fan fan2 = new Fan();
        fan2.Speed = 2;
        fan2.PrintInf();
    }
}