namespace Domain.Entities;

public class User
{
	public int IdUser { get; set; }
	public string Name { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;

	public User() {}

	public void UserInformation()
	{
		Console.WriteLine("User Information:");
		Console.WriteLine("ID: " + IdUser);
		Console.WriteLine("Name: " + Name);
		Console.WriteLine("Last Name: " + LastName);
	}
	
	public string RegisterUser()
	{
		Console.WriteLine("Welcome to our library!");
		Console.WriteLine("To register with us, please provide the following information: ");
		Console.Write("What's your first name? ");
		Name = Console.ReadLine() ?? string.Empty;
		Console.Write("What's your last name? ");
		LastName = Console.ReadLine() ?? string.Empty;

		return "User registered successfully.";
	}

	public void SetUserInformation(int idUser, string name, string lastName)
	{
		IdUser = idUser;
		Name = name;
		LastName = lastName;
	}

}