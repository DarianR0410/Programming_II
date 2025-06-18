using Domain;

namespace DAL;

public class SavingAccountDAO
{
	private ApplicationDbContext DbContext;
	public SavingAccount SavingAccount;
	public SavingAccountDAO(ApplicationDbContext databaseContext)
	{
		DbContext = databaseContext;
		SavingAccount = new SavingAccount();
	}
	
	public SavingAccount AddSavingAccount(decimal balance, int accountNumber, Customer customer)
	{
		if (balance < 0 || accountNumber == 0 || customer == null)
			return null;
		
		
		 SavingAccount = new SavingAccount { Balance = balance, AccountNumber = accountNumber, Customer = customer};
		 
			if (SavingAccount.AccountNumber == accountNumber)
			{
				DbContext.SavingAccounts.Add(SavingAccount);
				DbContext.SaveChanges();
			}
			
		return SavingAccount;
	}
	
	public SavingAccount GetSavingAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;

			if (SavingAccount.AccountNumber == accountNumber)
			{
				DbContext.SavingAccounts.FindAsync(accountNumber);
				DbContext.SaveChanges();
			}
		
		return SavingAccount; 
	}
	
	public SavingAccount DeleteSavingAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;

			if (SavingAccount.AccountNumber == accountNumber)
			{
				DbContext.SavingAccounts.FindAsync(SavingAccount);
				DbContext.SavingAccounts.Remove(SavingAccount);
				DbContext.SaveChanges();
				return SavingAccount;
			}
			
		return null; 
	}
}