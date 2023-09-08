using System.Diagnostics.Contracts;

public class Point_2D{
    public float x = 0.0f;
    public float y = 0.0f;
    public Point_2D(){

    }
    public Point_2D(float x, float y){
        this.x = x;
        this.y = y;
    }
    public float GetX(){
        return x;
    }
    public void SetX(float x){
        this.x = x;
    }
    public float GetY(){
        return y;
    }
    public void SetY(float y){
        this.y = y;
    }
    public void SetXY(float x, float y){
        this.x  = x;
        this.y = y;
    }
    public float[] GetXY(){
        return new float[]{x, y};
    }
    public override string ToString()
    {
        return $" x: {x}, y: {y} ";
    }

}
public class Point_3D: Point_2D{
    float z = 0.0f;
    public Point_3D(){

    }
    public Point_3D(float x, float y, float z) : base(x, y){
        this.z = z;
    }
    public float GetZ(){
        return z;
    }
    public void SetZ(float z){
        this.z = z;

    }
    public void SetXYZ(float x, float y, float z){
        SetX(x);
        SetY(y);
        this.z = z;


    }
    public float[] GetXYZ(){
        return new float[] {x, y, z};
    }
    public override string ToString()
    {
        return base.ToString() + $"z: {z}";
    }

}