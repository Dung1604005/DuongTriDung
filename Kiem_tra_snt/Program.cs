public class Program{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Nhap so n: ");
        n = Convert.ToInt32(Console.ReadLine());
        if ( n == 1 || n == 0){
            Console.Write("Khong phai so nguyen to");
        }
        else if (n == 2){
            Console.Write("Day la so nguyen to");
        }
        else{
            string output = "Day la so nguyen to";
            for(int i =2 ; i*i < n; i++){
                if ( n % i == 0){
                    output = "Khong phai la so nguyyen to";
                }

            }
            Console.Write(output);
        }
    }
}