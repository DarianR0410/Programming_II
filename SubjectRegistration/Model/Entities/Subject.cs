namespace SubjectRegistration;

public class Subject
{
	public string name { get; set; }
	public string code { get; set; }
	public int credits { get; set; }
	public string professor { get; set; }
	public DateTime time { get; set; }

	public int capacity { get; set; } = 25;


	public Subject()
	{
		this.name = name;
		this.code = code;
		this.credits = credits;
		this.professor = professor;
		this.time = time;
		this.capacity = capacity;
		
	}
	
}