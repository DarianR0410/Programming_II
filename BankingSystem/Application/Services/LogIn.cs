using Domain;

namespace Application;

public class LogIn
{
	public Customer Customer { get; set; }
	
	public LogIn(){
		Customer = new Customer();
	}

	public void SignIn(Customer Customer)
	{
		
	}

	public void SignOut()
	{
		
	}
}