using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

[Table("Customers", Schema = "LogIn")]
public class Customer
{
	[Key]
	public int Id { get; set; }
	public string Name { get; set; }
	public string LastName { get; set; }
	[Required]
	[MaxLength(255)]
	public string EmailAddress { get; set; }
	[Required]
	public string Password { get; set; }
	
	[InverseProperty("Customer")]
	public CurrentAccount? CurrentAccount { get; set; }
	
	[InverseProperty("Customer")]
	public SavingAccount? SavingAccount { get; set; }

	public Customer()
	{
		
	}
	
	public Customer(string name, string lastName, string emailAddress, string password, int id){
		CurrentAccount = new CurrentAccount();
		SavingAccount = new SavingAccount();
		this.Name = name;
		this.LastName = lastName;
		this.EmailAddress = emailAddress;
		this.Password = password;
		this.Id = id;

	}

}