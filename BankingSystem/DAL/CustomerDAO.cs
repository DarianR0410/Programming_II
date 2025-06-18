using Domain;

namespace DAL;

public class CustomerDAO
{
	private List<Customer> Customers;

	public CustomerDAO()
	{
		Customers = new List<Customer>();
	}
	
	public Customer AddCustomer(string name, string lastName, int id)
	{
		if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || id < 1)
			return null;
		
		Customer newCustomer = new Customer { Name = name, LastName = lastName, Id = id };
		
		for (int i = 0; i < Customers.Count; i++)
		{
			if (newCustomer.Name == Customers[i].Name && newCustomer.LastName == Customers[i].LastName && newCustomer.Id == Customers[i].Id)
			{
				return Customers[i]; 
			}
		}
		
		Customers.Add(newCustomer);
		return newCustomer;
	}
	
	public Customer GetCustomer(int id)
	{
		if (id < 1)
			return null;
		for (int i = 0; i < Customers.Count; i++)
		{
			if (Customers[i].Id == id)
			{
				return Customers[i];
			}
		}
		return null; 
	}
	
	public Customer DeleteCustomer(int id)
	{
		if (id < 1)
			return null;
		for (int i = 0; i < Customers.Count; i++)
		{
			if (Customers[i].Id == id)
			{
				Customer deletedCustomer = Customers[i];
				Customers.RemoveAt(i); 
				return deletedCustomer;
			}
		}
		return null; 
	}
	
	public List<Customer> GetAllCustomers()
	{
		if (Customers.Count == 0)
			return null;
		return Customers; 
	}
	
}