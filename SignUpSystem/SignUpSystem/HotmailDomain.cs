using System.Security.Cryptography;
using System.Text;

namespace SignUpSystem;

public class HotmailDomain : AEncrypt
{
	public static byte[] EncryptedData;
	

	public static string Hash(User user)
	{
		string password = user.Password;
		string key = "10987654321Random";

		using (Aes aes = Aes.Create())
		{
			aes.Key = Encoding.UTF8.GetBytes(key);
			aes.IV = new Byte[16];
			
			//Here must perform the stream transformation.
			ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(password);
					}
				}
				EncryptedData = memoryStream.ToArray();
				return Convert.ToBase64String(EncryptedData);
			}
		}
		
	}
}