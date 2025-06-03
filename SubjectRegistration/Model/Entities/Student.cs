namespace SubjectRegistration;

public class Student
{
	public string name { get; set; }
	public string lastName { get; set; }
	public int id { get; set; }
	public string InstitutionEmail { get; set; }
	public string career { get; set; }

	private List<Schedule> schedules;

	public Student()
	{
		schedules = new List<Schedule>();
		this.name = name;
		this.lastName = lastName;
		this.id = id;
		this.InstitutionEmail = InstitutionEmail;
		this.career = career;
	}
	
	
}