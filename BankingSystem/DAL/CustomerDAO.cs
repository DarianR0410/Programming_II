using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class CustomerDAO
{
	private ApplicationDbContext DbContext;
	public Customer Customer;

	public CustomerDAO(ApplicationDbContext databaseContext)
	{
		DbContext = databaseContext;
		Customer = new Customer();
	}

	public Customer SignIn(string emailAddress, string password)
	{
		if (string.IsNullOrEmpty(emailAddress) && string.IsNullOrEmpty(password))
			return null;

		if (Customer.EmailAddress == emailAddress && Customer.Password == password)
		{
			DbContext.Customers.Where(cus =>
				cus.EmailAddress.Contains(emailAddress) && cus.Password.Contains(password));
			return Customer;

		}
		
		return null;
	}
	
	public Customer AddCustomer(string name, string lastName, int id, string emailAddress, string password)
	{
		if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || id < 1)
			return null;
		
		Customer = new Customer { Name = name, LastName = lastName, Id = id, EmailAddress = emailAddress, Password = password};
		
			if (Customer.Name == name && Customer.LastName == lastName && Customer.Id == id && Customer.EmailAddress == emailAddress && Customer.Password == password)
			{
				DbContext.Customers.Add(Customer);
				DbContext.SaveChanges();
			}
			
			
			return Customer;
	}
	
	public Customer GetCustomerById(int id)
	{
		if (id < 1)
			return null;
		
			if (Customer.Id == id)
			{
				DbContext.Customers.FindAsync(id);
				DbContext.SaveChanges();
				return Customer;
			}

		return null; 
	}
	
	public Customer DeleteCustomer(int id)
	{
		if (id < 1)
			return null;
		
			if (Customer.Id == id)
			{
				DbContext.Customers.FindAsync(id);
				DbContext.Customers.Remove(Customer);
				DbContext.SaveChanges();
				return Customer;
			}

		return null; 
	}
	
}