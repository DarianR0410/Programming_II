namespace PracticaAula;
public class Bank
{
	private List<Customer> customers;
	private List<SavingAccount> savingAccounts;
	private List<CurrentAccount> currentAccounts;
	
	public Bank()
	{
		customers = new List<Customer>();
		savingAccounts = new List<SavingAccount>();
		currentAccounts = new List<CurrentAccount>();
	}
	
	public Customer AddCustomer(string name, string lastName, long id)
	{
		if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || id < 1)
			return null;
		
		
		Customer newCustomer = new Customer { name = name, lastName = lastName, Id = id };
		
		for (int i = 0; i < customers.Count; i++)
		{
			if (newCustomer.name == customers[i].name && newCustomer.lastName == customers[i].lastName && newCustomer.Id == customers[i].Id)
			{
				return customers[i]; 
			}
		}
		
		customers.Add(newCustomer);
		return newCustomer;
	}
	
	public Customer GetCustomer(long id)
	{
		if (id < 1)
			return null;
		for (int i = 0; i < customers.Count; i++)
		{
			if (customers[i].Id == id)
			{
				return customers[i];
			}
		}
		return null; 
	}
	
	public Customer DeleteCustomer(long id)
	{
		if (id < 1)
			return null;
		for (int i = 0; i < customers.Count; i++)
		{
			if (customers[i].Id == id)
			{
				Customer deletedCustomer = customers[i];
				customers.RemoveAt(i); 
				return deletedCustomer;
			}
		}
		return null; 
	}
	
	public List<Customer> GetAllCustomers()
	{
		if (customers.Count == 0)
			return null;
		return customers; 
	}
	
	public SavingAccount AddSavingAccount(decimal balance, long accountNumber, Customer customer)
	{
		if (balance < 0 || accountNumber == 0 || customer == null)
			return null;
		
		
		SavingAccount newAccount = new SavingAccount { balance = balance, accountNumber = accountNumber, customer = customer };
		
		for (int i = 0; i < savingAccounts.Count; i++)
		{
			if (savingAccounts[i].accountNumber == accountNumber)
			{
				return savingAccounts[i]; 
			}
		}
		
		savingAccounts.Add(newAccount);
		return newAccount;
	}
	
	public SavingAccount GetSavingAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < savingAccounts.Count; i++)
		{
			if (savingAccounts[i].accountNumber == accountNumber) 
			{
				return savingAccounts[i];
			}
		}
		return null; 
	}
	
	public SavingAccount DeleteSavingAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < savingAccounts.Count; i++) 
		{
			if (savingAccounts[i].accountNumber == accountNumber)
			{
				SavingAccount deletedAccount = savingAccounts[i];
				savingAccounts.RemoveAt(i);
				return deletedAccount;
			}
		}
		return null; 
	}
	
	public List<SavingAccount> GetAllSavingAccounts()
	{
		if (savingAccounts.Count == 0)
			return null;
		return savingAccounts; 
	}
	
	public CurrentAccount AddCurrentAccount(decimal balance, long accountNumber, Customer customer)
	{
		if (balance < 0 || accountNumber == 0 || customer == null)
			return null;
		
		
		CurrentAccount newAccount = new CurrentAccount { balance = balance, accountNumber = accountNumber, customer = customer };
		
		for (int i = 0; i < currentAccounts.Count; i++)
		{
			if (currentAccounts[i].accountNumber == accountNumber)
			{
				return currentAccounts[i]; 
			}
		}
		
		currentAccounts.Add(newAccount);
		return newAccount;
	}
	
	public CurrentAccount GetCurrentAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < currentAccounts.Count; i++)
		{
			if (currentAccounts[i].accountNumber == accountNumber) 
			{
				return currentAccounts[i];
			}
		}
		return null;
	}
	
	public CurrentAccount DeleteCurrentAccount(long accountNumber)
	{
		if (accountNumber <= 0)
			return null;
		for (int i = 0; i < currentAccounts.Count; i++) 
		{
			if (currentAccounts[i].accountNumber == accountNumber)
			{
				CurrentAccount deletedAccount = currentAccounts[i];
				currentAccounts.RemoveAt(i); 
				return deletedAccount;
			}
		}
		return null; 
	}
	
	public List<CurrentAccount> GetAllCurrentAccounts()
	{
		if (currentAccounts.Count == 0)
			return null;
		return currentAccounts; 
	}
}