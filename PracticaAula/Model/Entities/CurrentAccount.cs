namespace PracticaAula;

public class CurrentAccount : Account
{
	public long accountNumber { get; set; }
	public Customer customer;
	public decimal balance { get; set; }

	public CurrentAccount()
	{
		customer = new Customer();
	}

	public void DisplayBalance()
	{
		Console.WriteLine("Your current balance is: " + balance);
	}
	
	public void Deposit(decimal amount)
	{
		if (amount > 1000)
		{
			balance += amount;
			Console.WriteLine("Deposit of " + amount + " made. Your new balance is " + balance);
		}
		else
		{
			throw new ArgumentException("Your deposit muust be greater than 1000.");
		}
	}

	public void Withdraw(decimal amount)
	{
		balance -= amount;
		Console.WriteLine("Withdrawal of " + amount + " made. Your new balance is " + balance);

	}
}