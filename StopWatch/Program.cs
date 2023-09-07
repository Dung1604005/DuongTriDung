public class Program{
    static void sort(int []arr)
    {
        int n = arr.Length;
 
        // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;
 
            // Swap the found minimum element with the first
            // element
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
    static void Main(string[] args)
    {
        StopWatch watch = new StopWatch();
        watch.Start();
        int[] arr = {1,4,0,13,9,-1,39,9,4,82,9,1,4,-1,-93,-293,392,84,2};
        sort(arr);
        watch.Stop();
        watch.GetElapsedTime();
        
    }
}