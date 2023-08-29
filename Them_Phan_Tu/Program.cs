using System.Reflection.Metadata;

public class Program{
    static void Main(string[] args)
    {
        int[] number = new int[10];
        number[0] = 10;
        number[1] = 4;
        number[2] = 6;
        number[3] = 7;
        number[4] = 8;
        int add;
        add = Convert.ToInt32(Console.ReadLine());
        int vi_tri = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 4; i >= vi_tri-1; i--){
            number[i+1] = number[i];



        }
        number[vi_tri-1] = add;
        for(int i = 0; i < 10; i++){
            Console.WriteLine(number[i]);
        }
    }
}