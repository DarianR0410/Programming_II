namespace Domain;

public interface IBankAccount
{
	public void Deposit(decimal amount);
	public void Withdraw(decimal amount);
}