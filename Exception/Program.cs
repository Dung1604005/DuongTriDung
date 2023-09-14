public class Program{
    static void Main(string[] args)
    {
        try{
            char[] character = new char[5];
            character[0] = 'a';
            character[1] = 'b';
            character[2] = 'c';
            character[3] = 'd';
            character[4] = 'e';
            int val = character[5];


        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Wrong");

        }

    }
}