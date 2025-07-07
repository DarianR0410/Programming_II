using System.Text.Json;

namespace SignUpSystem;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		string Path = "C:\\Users\\Darian Ramos\\C#\\SignUpSystem\\SignUpSystem\\EncryptedData\\EncryptedData.json";

		while (isRunning)
		{
			Console.WriteLine("Hi, welcome to the sign up system");
			Console.Write("To sign up, please enter your email address: ");
			string email = Console.ReadLine();
			Console.Write("now, please enter your password: ");
			string password = Console.ReadLine();
			User newUser = new User();
			newUser.Email = email;
			newUser.Password = password;
			bool isSuccessful = EncryptFactory.EmailBasedEncryption(email, newUser);

			if (isSuccessful)
			{
				string JsonFile = JsonSerializer.Serialize(newUser, new JsonSerializerOptions {WriteIndented = true});
				File.WriteAllText(Path, JsonFile);
				Console.Write("You have succesfully signed up, bye bye for now!");
			}
			else
			{
				throw new Exception("Could not encrypt the password. Unable to sign up.");
			}
			
		}
		
	}
}