public class Program{
    static void Main(string[] args)
    {
        int[] arr = {1,4, 10, 22, 223};
        Console.WriteLine(Min(arr));
    }
    public static int Min(int[] arr){
        int min = arr[0];
        for(int i = 0; i < arr.Length; i++ ){
            if(arr[i] < min){
                min = arr[i];
            }
        }
        return min;
    }
}