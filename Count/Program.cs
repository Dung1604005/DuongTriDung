public class Program{
    static void Main(string[] args)
    {
        
    }
    static int count(string str, char a ){
        int count = 0;
        for(int i = 0; i < str.Length; i++){
            if(str[i] == a){
                count++;
            }
        }
        return count;
    }
}