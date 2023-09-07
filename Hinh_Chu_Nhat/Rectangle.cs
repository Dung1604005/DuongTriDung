public class Rectangle{
    double width;
    double height;
    public Rectangle(){

    }
    public Rectangle(double width, double height){
        this.width = width;
        this.height = height;
    }
    public double GetArea(){
        return this.width*this.height;
    }
    public double GetPerimeter(){
        return (this.width+this.height)*2;
    }
    public void Display(){
        for(int i = 0; i < this.height; i++){
            Console.Write("-");
        }
        Console.WriteLine("");
        for(int i = 0; i < this.width-2; i++){
            Console.Write("|");
            for(int j = 0; j < this.height-2; j++){
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine("");
        }
        for(int i = 0; i < this.height; i++){
            Console.Write("-");
        }
    }
}