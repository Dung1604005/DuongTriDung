public class Program{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Nhap so hang va cot: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Hay nhap phan tu trong bang");
        int[,] ma_tran = new int[n, n];
        for(int i = 0; i < n; i++ ){
            for(int j = 0; j < n; j++){
                ma_tran[i, j] = Convert.ToInt32(Console.ReadLine());

            }
        }
        int sum = 0;
        for(int i = 0; i < n; i++ ){
            sum += ma_tran[i, i];
                

        }
            
        
        Console.WriteLine(sum);
    }
}