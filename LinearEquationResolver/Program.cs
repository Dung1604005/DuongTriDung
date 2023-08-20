public class Program{
    static void Main(string[] args)
    {
        Console.Write("Linear Equation Resolver");
        Console.Write("Given a equation as 'a * x + b = 0', please enter constants:");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a != 0){
            double ans = -b/a;
            Console.Write("The solution is: {0}!", ans);
        }
        else{
            if (b == 0){
                Console.Write("The solution is all x!");
            }
            else{
                Console.Write("Nod solution!");
            }
        }
    }
}
