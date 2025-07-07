namespace SignUpSystem;

public class GmailDomain : AEncrypt
{

	public static string Hash(User user)
	{
		try
		{
			byte[] hashingPassword = System.Text.Encoding.UTF8.GetBytes(user.Password);
			string base64EncodedData = Convert.ToBase64String(hashingPassword);
		}
		catch (Exception)
		{
			throw new NullReferenceException("Password cannot be null");
		}

		if (user.Password != null)
			return "Password successfully hashed";
		else
			return "The password" + user.Password + " has been unable to be hashed, please check and try again.";
	}
}