using System.Security.Cryptography;
using System.Text;

namespace SignUpSystem;

public class ItlaDomain : AEncrypt
{
	private static byte[] Key = new byte[8];
	private static byte[] IV = new byte[8];
	private static string Path = "C:\\Users\\Darian Ramos\\C#\\SignUpSystem\\SignUpSystem\\EncryptedData\\EncryptedData.json";


	static ItlaDomain()
	{
		using (var rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(Key);
			rng.GetBytes(IV);
		}
	}
	public static string Encrypt(User user)
	{
		string password = user.Password;

		try
		{
			using (MemoryStream memoryStream= new MemoryStream()) 
			using (DES des = DES.Create()) 
			using (ICryptoTransform transform = des.CreateEncryptor(Key, IV))
			using (var cStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
			{
				byte[] toEncrypt = Encoding.UTF8.GetBytes(password);
				//This is supposed to write the byte array to the crypto stream:
				cStream.Write(toEncrypt, 0, toEncrypt.Length);
				cStream.FlushFinalBlock();
				byte[] encryptedPassword = memoryStream.ToArray();
				return Convert.ToBase64String(encryptedPassword);
			}
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine("An error has occured while encrypting: {0}", ex.Message);
			throw;
		}
		
	}
}