public class Prpgram{
    static void Main(string[] args)
    {
        string filepath = "test.csv";
        StreamReader read = new StreamReader(filepath);
        StreamWriter write = new StreamWriter("output.txt");
        string line;
        
        while((line = read.ReadLine()) != null){
            string[] read_doc = line.Split(',');
            
            
            for(int i = 1; i < read_doc[5].Length -1; i++){
                write.Write(read_doc[5][i]);

            }
            write.WriteLine("");
        


        }
        read.Close();
        write.Close();
    }
}