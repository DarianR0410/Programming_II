using DAL;

namespace Application;

public class BankingSystem
{
	private ApplicationDbContext DbContext;
	public CustomerDAO CustomerDao { get; set; }
	public CurrentAccountDAO CurrentAccountDao { get; set; }
	
	public SavingAccountDAO SavingAccountDao { get; set; }
	
	public BankingSystem(ApplicationDbContext databaseContext)
	{
		CustomerDao = new CustomerDAO(databaseContext);
		DbContext = databaseContext;
		CurrentAccountDao = new CurrentAccountDAO(DbContext);
		SavingAccountDao = new SavingAccountDAO(DbContext);
		
	}

	public void RegisterCustomer(string name, string lastName, string emailAddress, string password, int id)
	{
		CustomerDao.AddCustomer(name, lastName, id, emailAddress, password);
	}

	public void SignIn(string emailAddress, string password)
	{
		
	}

	public void GetCustomerById(int id)
	{
		
	}

	public void DeleteAccount()
	{
		
	}

	public void OpenSavingAccount()
	{
		
	}

	public void OpenCurrentAccount()
	{
		
	}

	public void CheckSavingAccount()
	{
		
	}

	public void CheckCurrentAccount()
	{
		
	}
}
