using Domain;

namespace DAL;

public class CurrentAccountDAO
{
	private List<CurrentAccount> CurrentAccounts;
	

	public CurrentAccountDAO()
	{
		CurrentAccounts = new List<CurrentAccount>();
	}
	
	public CurrentAccount AddCurrentAccount(decimal balance, long accountNumber, Customer Customer)
	{
		if (balance < 0 || accountNumber == 0 || Customer == null)
			return null;
		
		
		CurrentAccount newAccount = new CurrentAccount { Balance = balance, AccountNumber = accountNumber, Customer = Customer };
		
		for (int i = 0; i < CurrentAccounts.Count; i++)
		{
			if (CurrentAccounts[i].AccountNumber == accountNumber)
			{
				return CurrentAccounts[i]; 
			}
		}
		
		CurrentAccounts.Add(newAccount);
		return newAccount;
	}
	
	public CurrentAccount GetCurrentAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < CurrentAccounts.Count; i++)
		{
			if (CurrentAccounts[i].AccountNumber == accountNumber) 
			{
				return CurrentAccounts[i];
			}
		}
		return null;
	}
	
	public CurrentAccount DeleteCurrentAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < CurrentAccounts.Count; i++) 
		{
			if (CurrentAccounts[i].AccountNumber == accountNumber)
			{
				CurrentAccount deletedAccount = CurrentAccounts[i];
				CurrentAccounts.RemoveAt(i); 
				return deletedAccount;
			}
		}
		return null; 
	}
}