public class Circle{
    protected double radius;
    public Circle(double radius){
        this.radius = radius;
    }
    public double GetR(){
        return radius;
    }
}
public interface IComparerCircle{
    public int Compare(Circle c1, Circle c2);
}
public class CompareCircle: IComparerCircle{
    public int Compare(Circle c1, Circle c2){
        if(c1.GetR() > c2.GetR()){
            return 1;
        }
        if(c1.GetR() < c2.GetR()){
            return 2;
        }
        else{
            return 0;
        }
    }
}