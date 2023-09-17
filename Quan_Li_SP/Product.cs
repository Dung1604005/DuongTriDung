public class Product{
    public int id;
    public string name;
    public string company;
    public string price;
    public Product(string name, string company, string price){
        Random rd = new Random();
        id = rd.Next(100000, 999999);
        this.name = name;
        this.company = company;
        this.price= price;
    }
}