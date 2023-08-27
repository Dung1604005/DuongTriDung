public class Program{
    static void Main(string[] args)
    {
        int col, row;
        Console.WriteLine("Nhap so hang: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so cot: ");
        col = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hay nhap phan tu trong bang");
        int[,] ma_tran = new int[row, col];
        for(int i = 0; i < row; i++ ){
            for(int j = 0; j < col; j++){
                ma_tran[i, j] = Convert.ToInt32(Console.ReadLine());

            }
        }
        int max = ma_tran[0, 0];
        for(int i = 0; i < row; i++ ){
            for(int j = 0; j < col; j++){
                if (max < ma_tran[i, j]){
                    max = ma_tran[i, j];
                }

            }
            
        }
        Console.WriteLine(max);
    }
}