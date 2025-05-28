namespace PracticaAula;

public class SavingAccount : Account
{
	public long accountNumber { get; set; }
	public decimal balance { get; set; }
	public Customer customer;
	
	public SavingAccount()
	{
		customer = new Customer();

	}

	public void DisplayBalance()
	{
		Console.WriteLine("Your current balance is: " + balance);
	}
	public void Deposit(decimal amount)
	{
		balance += amount;
		Console.WriteLine("Deposit of " + amount + " made. Your new balance is " + balance);
	}

	public void Withdraw(decimal amount)
	{
		decimal value = this.balance * 0.5m;
		
		if (value < amount)
		{
			balance -= amount;
			Console.WriteLine("Withdrawal of " + amount + " made. Your new balance is " + balance);
		}
		else
		{
			throw new ArgumentException("You can only withdraw up to 50% of your available balance.");
		}
	}
}