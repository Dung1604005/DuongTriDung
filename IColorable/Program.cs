using Shape;

public class Program{
    static void Main(string[] args)
    {
        Shapes[] arr = new Shapes[4];
        arr[0] = new Circle(3);
        
        
        arr[1] = new Rectangle(3, 4);
        arr[2] = new Square(3);
        arr[3] = new Circle(1);
        
        
        for(int i = 0; i < 4; i++){
           if (arr[i] is Square){
            Square square = new Square();
            square.HowToColor();
               
           }
           
          
        }
    }
}