using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL;

public class DesignTimeDbContextF : IDesignTimeDbContextFactory<ApplicationDbContext>
{
	public ApplicationDbContext CreateDbContext(string[] args)
	{
		var connection = "Server=localhost;Database=BankingDb;Trusted_Connection=true;TrustServerCertificate=true;";

		var OptionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
		
		OptionBuilder.UseSqlServer(connection);

		return new ApplicationDbContext(OptionBuilder.Options);
	}
}