public class Program{
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for(int i =0; i < n; i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = 0;
        for(int i = 0; i < n; i++){
            if ( max < arr[i] ){
                max = arr[i];
            }
        }
        Console.Write(max);

    }
}