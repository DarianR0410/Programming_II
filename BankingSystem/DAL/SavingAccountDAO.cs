using Domain;

namespace DAL;

public class SavingAccountDAO
{
	private List<SavingAccount> SavingAccounts;

	public SavingAccountDAO()
	{
		SavingAccounts = new List<SavingAccount>();
	}
	
	public SavingAccount AddSavingAccount(decimal balance, int accountNumber, Customer customer)
	{
		if (balance < 0 || accountNumber == 0 || customer == null)
			return null;
		
		
		SavingAccount newAccount = new SavingAccount { Balance = balance, AccountNumber = accountNumber, Customer = customer };
		
		for (int i = 0; i < SavingAccounts.Count; i++)
		{
			if (SavingAccounts[i].AccountNumber == accountNumber)
			{
				return SavingAccounts[i]; 
			}
		}
		
		SavingAccounts.Add(newAccount);
		return newAccount;
	}
	
	public SavingAccount GetSavingAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < SavingAccounts.Count; i++)
		{
			if (SavingAccounts[i].AccountNumber == accountNumber) 
			{
				return SavingAccounts[i];
			}
		}
		return null; 
	}
	
	public SavingAccount DeleteSavingAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < SavingAccounts.Count; i++) 
		{
			if (SavingAccounts[i].AccountNumber == accountNumber)
			{
				SavingAccount deletedAccount = SavingAccounts[i];
				SavingAccounts.RemoveAt(i);
				return deletedAccount;
			}
		}
		return null; 
	}
}