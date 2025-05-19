namespace Library;

public class User
{
    private int idUser { get; set; }
    private String name { get; set; }
    private String lastName { get; set; }
    
    public User()
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

    public String RegisterUser()
    {

        Console.WriteLine("Welcome to our library!");
        Console.WriteLine("To register with us, please provide the following information: ");
        Console.Write("What's your first name? ");
        name = Console.ReadLine();
        Console.Write("What's your last name? ");
        lastName = Console.ReadLine();
        
        return "User registered successfully.";
    }

    public void SetUserInformation(String name, String lastName)
    {
        this.name = name;
        this.lastName = lastName;
    }
}