using Domain.Entities;

namespace Data;

public class UserDal
{
	private List<User> libraryUsers;

	public UserDal()
	{
		libraryUsers = new List<User>();
	}
	
	public string RegisterUser(User user)
	{
		Console.WriteLine("Welcome to our library!");
		Console.WriteLine("To register with us, please provide the following information: ");

		Console.Write("What's your ID? ");
		if (!int.TryParse(Console.ReadLine(), out int idUser))
		{
			return "Invalid ID.";
		}

		Console.Write("What's your first name? ");
		string? name = Console.ReadLine();

		Console.Write("What's your last name? ");
		string? lastName = Console.ReadLine();

		if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName))
		{
			return "Name and last name cannot be empty.";
		}

		user.SetUserInformation(idUser, name, lastName);
		libraryUsers.Add(user);

		return "User registered successfully.";
	}
}