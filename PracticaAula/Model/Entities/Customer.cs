namespace PracticaAula;

public class Customer
{
	public long Id { get; set; }
	public string name { get; set; }
	public string lastName { get; set; }
	public List<SavingAccount> savingAccount;
	public List<CurrentAccount> currentAccount;

	public Customer()
	{
		savingAccount = new List<SavingAccount>();
		currentAccount = new List<CurrentAccount>();

	}
	
}