namespace gymNet8.models;

public class Client
{
    public long id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string telephone { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }

    public Client(string name, string email, string telephone)
    {
        this.name = name;
        this.email = email;
        this.telephone = telephone;
        this.created_at = DateTime.Now;
    }
}