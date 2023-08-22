public class Program{
    static void Main(string[] args)
    {
        Console.Write("Nhap so n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string str = "";
        if ( n < 20){
            switch(n){
                case 1:
                    str += "one";
                    break;
                case 2:
                    str += "two";
                    break;
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;
                case 10:
                    str += "ten";
                    break;
                case 11:
                    str += "eleven";
                    break;
                case 12:
                    str += "twelve";
                    break;
                case 13:
                    str += "thirteen";
                    break;
                case 14:
                    str += "fourteen";
                    break;
                case 15:
                    str += "fifteen";
                    break;
                case 16:
                    str += "sixteen";
                    break;
                case 17:
                    str += "seventeen";
                    break;
                case 18:
                    str += "eightteen";
                    break;
                case 19:
                    str += "nineteen";
                    break;
                }
        
        


                
        }
        else if(n >= 20 && n < 30){
            int don_vi = n % 10;
            str = "twenty ";
            switch(don_vi){
                case 1:
                    str += "one";
                    break;
                case 2:
                    str += "two";
                    break;
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;
                
            }
        
        
        }
        else if (n >= 30 && n <100){
            int hang_chuc = n/10;
            int don_vi = n%10;
            switch(hang_chuc){
                case 3:
                    str += "thir";
                    break;
                case 4:
                    str += "for";
                    break;
                case 5:
                    str += "fif";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eigh";
                    break;
                case 9:
                    str += "nine";
                    break;
                
            }
            str += "ty ";
            switch(don_vi){
                case 1:
                    str += "one";
                    break;
                case 2:
                    str += "two";
                    break;
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;
                
            }
        }
        else if ( 100 <= n && n< 1000){
            int tram = n /100;
            int chuc = (n-tram*100)/10;
            int don_vi = n - tram*100 - chuc*10;
            switch(tram){
                case 1:
                    str += "one";
                    break;
                case 2:
                    str += "two";
                    break;
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;
                
            }
            str += " hundred and ";
            if (chuc > 2){
                switch(chuc){
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;
                
                }
                str+= "ty ";
                switch(don_vi){
                case 1:
                    str += "one";
                    break;
                case 2:
                    str += "two";
                    break;
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;


                }
            
           }
           else{
            int chuc_don_vi = chuc*10+don_vi;
            if (chuc_don_vi<=19){
                switch(chuc_don_vi){
                case 1:
                    str += "one";
                    break;
                case 2:
                    str += "two";
                    break;
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;
                case 10:
                    str += "ten";
                    break;
                case 11:
                    str += "eleven";
                    break;
                case 12:
                    str += "twelve";
                    break;
                case 13:
                    str += "thirteen";
                    break;
                case 14:
                    str += "fourteen";
                    break;
                case 15:
                    str += "fifteen";
                    break;
                case 16:
                    str += "sixteen";
                    break;
                case 17:
                    str += "seventeen";
                    break;
                case 18:
                    str += "eightteen";
                    break;
                case 19:
                    str += "nineteen";
                    break;
                }
            }
            else{
                str += "twenty ";
                switch(don_vi){
                case 1:
                    str += "one";
                    break;
                case 2:
                    str += "two";
                    break;
                case 3:
                    str += "three";
                    break;
                case 4:
                    str += "four";
                    break;
                case 5:
                    str += "five";
                    break;
                case 6:
                    str += "six";
                    break;
                case 7:
                    str += "seven";
                    break;
                case 8:
                    str += "eight";
                    break;
                case 9:
                    str += "nine";
                    break;
                
            }

            }

           }
        Console.Write(str);
        }
    }
}