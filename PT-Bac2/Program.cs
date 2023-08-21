public class Program{
    static void Main(string[] args)
    {
        Console.Write("Phuong trinh bac 2 co dang a.x^2 + b.x + c = 0");
        Console.Write("Nhap a : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        double delta = Math.Pow(b, 2) - 4*a*c;
        if ( a == 0){
            if (c != 0){
            double ans = -b/c;
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
        else {
            if (delta < 0){
                Console.Write("Phuong trinh vo nghiem");
            }
            else if(delta ==  0){
                Console.Write($"Phuong trinh co nghiem kep la: {-b/(2*a)}" );
            }
            else{
                Console.Write("Phuong trinh co 2 nghiem la: ");
                Console.Write($"x1: {(-b-Math.Sqrt(delta))/(2*a)}, ");
                Console.Write($"x2: {(-b+(Math.Sqrt(delta)))/(2*a)}");
        }
        }
    }
}
