using System.Data;
using System.Linq.Expressions;
using System.Xml;
using System.Xml.Linq;


public class Book
{
    public string Title { get; set; }
    public float Price { get; set; }
    public void ReadFromFile()
    {
        XmlTextReader reader = new XmlTextReader("books.xml");
        while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("");
                        break;
                }
            }
        
    }
    public Book(string Title, float Price){
        this.Title = Title;
        this.Price = Price;
    }
    public void WriteToFile(){
        Book book = new Book("Đắc Nhân Tâm", 125f);
        try{
            XDocument XDoc = XDocument.Load("books.xml");
            XElement newBook = new XElement("book",
            new XElement("title", book.Title),
            new XElement("price", book.Price.ToString()));
            XDoc.Element("bookstore").Add(newBook);
            XDoc.Save("books.xml");


        }catch(Exception ex){
            Console.WriteLine(ex);

        }

    }
}
