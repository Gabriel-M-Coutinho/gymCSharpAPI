using System.Runtime.InteropServices.JavaScript;

namespace gymNet8.models;

public class User
{
    public long id { get; set; }
    public string name { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    
    public string phone { get; set; }
    public DateTime birthDate { get; set; }


    public User(string name, string password, string email, string phone, DateTime birthDate)
    {
        this.name = name;
        this.password = password;
        this.email = email;
        this.phone = phone;
        this.birthDate = birthDate;
    }
    
}