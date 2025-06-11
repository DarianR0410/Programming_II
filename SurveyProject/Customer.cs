namespace SurveyProject;

public class Customer
{
	public string Name { get; set; }
	public long Id { get; set; }
	public int Score { get; set; }

	public Customer()
	{
		this.Name = Name;
		this.Score = 0;
		this.Id = Id;
	}

}