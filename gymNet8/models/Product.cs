namespace gymNet8.models;

public class Product
{
    public long id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string category { get; set; }
    public int quantity { get; set; }
    public double price { get; set; }
    public string category_name { get; set; }
    public string image { get; set; }

    public Product(string name, string description, string category, int quantity, double price, string categoryName, string image)
    {
        this.name = name;
        this.description = description;
        this.category = category;
        this.quantity = quantity;
        this.price = price;
        category_name = categoryName;
        this.image = image;
    }
}