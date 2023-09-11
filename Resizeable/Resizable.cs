using System.Runtime.Intrinsics.Arm;

public interface IResizeable{
    public void Resize(double percent);
}

public class Shape{
    Random rd = new Random();

    public string color = "green";
    public bool filled = true;
    
    public Shape(){

    }
    public Shape(string color, bool filled){
        this.color = color;
        this.filled = filled;
    }
    public override string ToString()
    {
        if (filled){
            return $"A Shape with color of {color} and filled";

        }
        return $"A Shape with color of {color} and not filled";
    }
    public string GetColor(){
        return color;
    }
    public bool IsFilled(){
        return filled;
    }
    public void SetColor(string color){
        this.color = color;
    }
    public void SetFilled(bool filled){
        this.filled = filled;
    }
}
public class Circle: Shape, IResizeable{
    private double radius = 1.0;
    
    
    
    public void Resize(double percent){
        this.radius = radius*(1+percent);

    }
    public Circle(){

    }
    public Circle(double radius){
        this.radius = radius;
    }
    public Circle(double radius, string color, bool filled) : base(color, filled){
        this.radius = radius;

    }
    public double GetRadius()

    {

            return radius;

    }
    public void SetRadius(double radius){
        this.radius = radius;
    }
    public double GetArea(){
        return radius*radius*Math.PI;
    }
    public double GetPerimeter(){
        return 2*radius*Math.PI;
    }
    public override string ToString()
    {
        return $"A Circle with radius = {radius}, which is a subclass of" + base.ToString();
    }
}
public class Rectangle: Shape{
    private double width = 1.0;
    private double length = 1.0;
    public void Resize(double percent){
        this.width = width*(1+percent);
        this.length = length*(1+percent);

    }
    public Rectangle(){

    }
    public Rectangle(string color, bool filled, double width, double length) : base(color, filled){
        this.width = width;
        this.length = length;
    }
    public double GetArea(){
        return width*length;
    }
    public double GetPerimeter(){
        return 2*(width+length);
    }
    public override string ToString()
    {
        return $"A Rectangle with width = {width} and length = {length}, which is a subclass of "+ base.ToString();
    }
}
public class Square: Rectangle{
    public Square(){

    }
    
    public Square(double side, String color, bool filled) : base(color, filled, side, side)

    {
        

    }
    
}