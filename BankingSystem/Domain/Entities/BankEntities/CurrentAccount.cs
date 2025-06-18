using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

[Table("CurrentAccount", Schema = "LogIn")]
public class CurrentAccount : IBankAccount
{
	[Key]
	public int AccountNumber { get; set; }
	[Required]
	public decimal Balance { get; set; }
	
	[ForeignKey(nameof(IdCustomer))]
	public Customer Customer { get; set; }
	
	public int IdCustomer { get; set; }

	public CurrentAccount()
	{
		Customer = new Customer();
		this.Balance = Balance;
		this.AccountNumber = AccountNumber;
	}
	
	public void Deposit(decimal amount)
	{
		Balance += amount;
		Console.WriteLine("Deposit of " + amount + " made. Your new balance is " + Balance);
	}

	public void Withdraw(decimal amount)
	{
		decimal value = this.Balance * 0.5m;
		
		if (value < amount)
		{
			Balance -= amount;
			Console.WriteLine("Withdrawal of " + amount + " made. Your new balance is " + Balance);
		}
		else
		{
			throw new ArgumentException("You can only withdraw up to 50% of your available balance.");
		}
	}
	
	
}