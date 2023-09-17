using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Vui long chon dich vu: ");
        Console.WriteLine("1: Them San Pham");
        Console.WriteLine("2: Hien Thi Tat Ca San Pham");
        Console.WriteLine("3: Tim Kiem San Pham");
        int choice;
        choice = Convert.ToInt32(Console.ReadLine());
        while(choice < 1 || choice > 3){
            choice = Convert.ToInt32(Console.ReadLine());
        }
        if (choice == 1){
            StreamWriter write = new StreamWriter("info.txt", true);
            
            Console.WriteLine("Vui Long Dien Ten San Pham");
            string name = Console.ReadLine();
            
            write.WriteLine($"Name: {name}");
            
            Random rd = new Random();
            int id = rd.Next(100000, 999999);
            write.WriteLine($"ID: {id}");
        
            
            Console.WriteLine("Vui long nhap gia");
            string price = Console.ReadLine();
            write.WriteLine($"Price: {price}$");
            Console.WriteLine("Vui long nhap hang san xuat");
            string company = Console.ReadLine();
            write.WriteLine($"Company: {company}");
            write.Close();
        }
        if (choice == 2){
            StreamReader read = new StreamReader("info.txt");
            string line;
            while((line = read.ReadLine()) != null){
                Console.WriteLine(line);
            }
            read.Close();
        }
        if (choice == 3){
            Console.WriteLine("Nhap Ten San Pham Muon Tim");
            string name = Console.ReadLine();
            bool find = false;
            StreamReader read = new StreamReader("info.txt");
            string line;
            while((line = read.ReadLine()) != null){
                if (line == $"Name: {name}"){
                    Console.WriteLine(line);
                    find = true;
                    for(int i = 0; i < 3; i++){
                        Console.WriteLine(read.ReadLine());
                    }
                    
                }
                
            }
            if (!find){
                Console.WriteLine("Khong Tim Thay San Pham");
            }
            

        }
    }
}