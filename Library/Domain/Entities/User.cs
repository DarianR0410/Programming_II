namespace Library.Domain.Entities;

public class User
{
    public int idUser { get; set; }
    public String name { get; set; }
    public String lastName { get; set; }

    public User()
    {
        
    }
    
    public User(int idUser, String name, String lastName)
    {
        this.idUser = idUser;
        this.name = name;
        this.lastName = lastName;
    }

    public void UserInformation()
    {
        // this method is used to display the information of the user.
        Console.WriteLine("User Information:");
        Console.WriteLine("ID: " + idUser);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Last Name: " + lastName);
    }

    public void SetUserInformation(String name, String lastName)
    {
        this.name = name;
        this.lastName = lastName;
    }
}