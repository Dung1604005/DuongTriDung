public class Program{
    static void Main(string[] args)
    {
        Student.Change();
        Student stu = new Student(111, "Hoang");
        stu.print();
    }
}