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
    }

    public String RegisterUser()
    {
        // this method is used to register a user.
        return "User registered successfully.";
    }
}