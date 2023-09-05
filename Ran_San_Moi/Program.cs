using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Principal;

public class Program
{
    static int x = 5;
    static int y = 5;
    static int len = 1;
    static int points = 0;
    static int fruit_x = 10;
    static int fruit_y = 10;
    static int[] X = new int[50];
    static int[] Y = new int[50];
    static int length = 50;
    static int width = 12;
    public void Start()
    {

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Random random = new Random();
        


        if (keyInfo.Key == ConsoleKey.UpArrow)
        {
            y--;
            
        }
        if (keyInfo.Key == ConsoleKey.DownArrow)
        {
            y++;
        }
        if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            x--;
        }
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            x++;
        }
        if( x == fruit_x && y == fruit_y){
            len++;
            fruit_x = random.Next(5, 40);
            fruit_y = random.Next(3, 10);
            
           
            for(int j = 0; j < len+1 ; j++){
                if(X[j]== fruit_x && Y[j] == fruit_y){
                        
                    fruit_x = random.Next(5, 40);
                    fruit_y = random.Next(3, 10);
                    break;

                }
            }
            points++;
            

            Draw(fruit_x, fruit_y, '+');
        }
        X[0] = x;
        X[len+1] = X[len];
        Y[len+1] = Y[len];
        Y[0] = y;
        for(int i = len+1; i > 1; i--){
            X[i-1] = X[i-2];
            Y[i-1] = Y[i-2];
        }
        for(int i = 0; i < len+1; i++){
            Draw(X[i], Y[i], 'O');
        }
        Draw(X[len+1], Y[len+1], ' ');

    }

    public  void Create()
    {
         Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("");
        for (int i = 1; i < width - 1; i++)
        {
            Console.Write("|");
            for (int j = 0; j < length - 2; j++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine("");
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write("-");
        }


    }
    public  void Draw(int x, int y, char a)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(a);
    }
    public void Draw_point(){
        Console.SetCursorPosition(2, 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Points: " );
        Console.Write(points);

    }
    public static void Main(string[] args)
    { 
        Program pg = new Program();
        pg.Create();
        pg.Draw(fruit_x, fruit_y, '+');
        pg.Draw_point();
        while(x < length-1 && y < width+1 && x > 1 && y > 1){
            pg.Start();
            pg.Draw_point();
            

        }
        
        Console.Write("Game Over!!");
        Console.Clear();

        
        
        
    }



}




