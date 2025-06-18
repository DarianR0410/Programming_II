using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

[Table("SavingAccount", Schema = "LogIn")]
public class SavingAccount : IBankAccount
{
	
	[Key]
	public int AccountNumber { get; set; }
	[Required]
	public decimal Balance { get; set; }
	
	[ForeignKey(nameof(IdCustomer))]
	public Customer Customer { get; set; }
	
	public int IdCustomer { get; set; }

	public SavingAccount()
	{
		
	}

	public SavingAccount(int balance)
	{
		Customer = new Customer();
		this.Balance = balance;
	}
	
	public void Deposit(decimal amount)
	{
		if (amount > 1000)
		{
			Balance += amount;
			Console.WriteLine("Deposit of " + amount + " made. Your new balance is " + Balance);
		}
		else
		{
			throw new ArgumentException("Your deposit muust be greater than 1000.");
		}
	}

	public void Withdraw(decimal amount)
	{
		Balance -= amount;
		Console.WriteLine("Withdrawal of " + amount + " made. Your new balance is " + Balance);

	}
}