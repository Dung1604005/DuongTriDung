public class Program{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.Write("\nMenu\n");
            Console.Write("1.Draw the triangle\n");
            Console.Write("2.Draw the square\n");
            Console.Write("3.Draw the rectangle\n");
            Console.Write("0.Exit\n");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.Write("* * * * *\n");
                    Console.Write("* * * *\n");
                    Console.Write("* * *\n");
                    Console.Write("* *\n");
                    Console.Write("*");
                    break;
                case 2:
                    Console.Write("* * * * * *\n");
                    Console.Write("* * * * * *\n");
                    Console.Write("* * * * * *\n");
                    Console.Write("* * * * * *\n");
                    Console.Write("* * * * * *\n");
                    Console.Write("* * * * * *\n");
                    break;
                case 3:
                    Console.Write("* * * * * *\n");
                    Console.Write("* * * * * *\n");
                    Console.Write("* * * * * *\n");
                    break;
            }
        
        } while(choice != 0);
        
        
    }
}