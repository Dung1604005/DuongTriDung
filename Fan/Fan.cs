public class Fan{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;
    int speed = SLOW;
    bool IsOn= false;
    double radius = 5f;
    string color = "blue";

    public int Speed { get => speed; set => speed = value; }
    public bool IsOn1 { get => IsOn; set => IsOn = value; }
    public double Radius { get => radius; set => radius = value; }
    public string Color { get => color; set => color = value; }
    public void SetSpeed(int speed){
        this.speed = speed;
    }
    public void PrintInf(){
        if (IsOn){
            Console.Write("Speed: ");
            Console.WriteLine(speed);
            Console.Write("Color: ");
            Console.WriteLine(color);
            Console.Write("Radius: ");
            Console.WriteLine(radius);
            Console.Write("Fan is on");


        }

    }
    public Fan(){
        
    }
    public Fan(int speed, bool IsOn, string color, double radius){
        this.speed = speed;
        this.color = color;
        this.IsOn= IsOn;
        this.radius = radius;

    }
}