public class Program{
    static void Main(string[] args)
    {
        int[] arr = {10, 4, 5, 7, 8};
        Delete(arr, 10);
        for(int i = 0; i < arr.Length-1; i++){
            Console.WriteLine(arr[i]);
        }
    }
    static void Delete(int[] arr, int x){
        int index = 0;
        for(int i = 0; i < arr.Length; i++){
            if (arr[i] == x){
                index = i;
            }
        }
        for(int i = index; i < arr.Length-1; i++){
            arr[i] = arr[i+1];
        }
    }
}