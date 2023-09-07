using System.ComponentModel;

public class Student{
    int rollno;
    string name;
    static string  college = "PTIT";
    public Student(int r , string n){
        this.rollno = r;
        this.name = n;
    }
    public static void Change(){
        college = "CODEGYM";
    }
    public void print(){
        Console.Write("name: ");
        Console.WriteLine(name);
        Console.Write("college: ");
        Console.Write(college);
    }
    
        
    
}