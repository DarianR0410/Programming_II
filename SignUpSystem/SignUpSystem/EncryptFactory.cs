namespace SignUpSystem;

public class EncryptFactory
{
	public static bool EmailBasedEncryption(string emailFormat, User user)
	{
		string encryptedPassword = "";
		
		if (emailFormat.Equals("@hotmail.com"))
		{ 
			encryptedPassword = HotmailDomain.Encrypt(user);
			
		} else if (emailFormat.Equals("@gmail.com"))
		{ 
			encryptedPassword = GmailDomain.Encrypt(user);
		}
		else
		{
			encryptedPassword = ItlaDomain.Encrypt(user);
		}
		
		user.Password = encryptedPassword;
		
		return true;
	}
}