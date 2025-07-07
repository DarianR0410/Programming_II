using System.Security.Cryptography;

namespace SignUpSystem;

public class ItlaDomain : AEncrypt
{
	private static byte[] Key;
	private static byte[] IV;

	public static string Hash(User user)
	{
		string password = user.Password;

		using (DES des = DES.Create())
		{
			Key = des.Key;
			IV = des.IV;
		}
		
		return null;
	}
}