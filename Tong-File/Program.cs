public class Program{
    static void Main(string[] args)
    {
        string filepath = "Text.txt";
        StreamReader read = new StreamReader(filepath);
        int sum = 0;
        string line;
        while((line = read.ReadLine()) != null){
            int p = Convert.ToInt32(line);
            sum += p;

        }
        read.Close();
        Console.WriteLine(sum);

    }
}