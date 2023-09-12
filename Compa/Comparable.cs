public class Circle{
    protected double radius;
    public Circle(double radius){
        this.radius = radius;

    }
}
public interface IComparable{
    public int Compare(double radius2);
}
public class ComparableCircle: Circle, IComparable{
    public ComparableCircle(double radius): base(radius){
        this.radius = radius;

    }
    public int Compare(double radius2){
        if(radius > radius2){
            return 1;
        }
        else{
            return 0;
        }

    }
}