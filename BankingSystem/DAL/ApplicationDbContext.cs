using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL;


public class ApplicationDbContext : DbContext
{
	
	public DbSet<Customer> Customers { get; set; }
	public DbSet<SavingAccount> SavingAccounts { get; set; }
	public DbSet<CurrentAccount> CurrentAccounts { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionContext) : base(optionContext)
	{
		
	}
	
	
	
}