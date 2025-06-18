using Domain;

namespace DAL;

public class CurrentAccountDAO
{
	private ApplicationDbContext DbContext;
	public CurrentAccount CurrentAccount;

	public CurrentAccountDAO(ApplicationDbContext databaseContext)
	{
		DbContext = databaseContext;
		CurrentAccount = new CurrentAccount();
	}
	
	public CurrentAccount AddCurrentAccount(decimal balance, int accountNumber, Customer Customer)
	{
		if (balance < 0 || accountNumber == 0 || Customer == null)
			return null;
		
		CurrentAccount = new CurrentAccount { Balance = balance, AccountNumber = accountNumber, Customer = Customer };

			if (CurrentAccount.AccountNumber == accountNumber)
			{
				DbContext.CurrentAccounts.Add(CurrentAccount);
				DbContext.SaveChanges();
			}
	
		return CurrentAccount;
	}
	
	public CurrentAccount GetCurrentAccount(int accountNumber)
	{
		if (accountNumber <= 0)
			return null;

			if (CurrentAccount.AccountNumber == accountNumber)
			{
				DbContext.CurrentAccounts.FindAsync(accountNumber);
				DbContext.SaveChanges();
			}
		
		return null;
	}
	
	public CurrentAccount DeleteCurrentAccount(int accountNumber)
	{
		if (accountNumber <= 0)
			return null;

			if (CurrentAccount.AccountNumber == accountNumber)
			{
				DbContext.CurrentAccounts.FindAsync(accountNumber);
				DbContext.CurrentAccounts.Remove(CurrentAccount);
				DbContext.SaveChanges();
				return CurrentAccount;
			}

			return null;
	}
}