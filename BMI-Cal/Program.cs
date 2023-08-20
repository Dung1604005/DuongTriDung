using System.Runtime.Intrinsics.X86;

public class Program{
    static void Main(string[] args)
    {
        float height;
        float weight;
        Console.Write("Please enter your height: ");
        height = float.Parse(Console.ReadLine());
        Console.Write("Please enter your weight: ");
        weight = float.Parse(Console.ReadLine());
        double bmi = weight / (height*height);
        bmi = Math.Round(bmi, 2);
        if (bmi < 18.5f){
            Console.Write("Underweight");
        }
        else if (bmi < 25f){
            Console.Write("Normal");
        }
        else if (bmi < 30f){
            Console.Write("Overweight");
        }
        else {
            Console.Write("Obese");
        }
    }
}
