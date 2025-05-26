namespace Library.Domain.Entities;

public class UserManagement
{
	public User user { get; set; }

	public UserManagement()
	{
		user = new User();
	}

	public void RegisterUser()
	{
		// Here comes the logic to register the users.
	}
	
	public void UserInformation()
	{
		// Logic to look for the user information.
	}
}