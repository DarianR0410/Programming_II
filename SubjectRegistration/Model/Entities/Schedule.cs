namespace SubjectRegistration;

public class Schedule
{
	public Student student { get; set; }
	public Subject subject { get; set; }
	public string semester { get; set; }
	
	public List<Subject> subjects { get; set; }
	
	public Schedule()
	{
		subjects = new List<Subject>();
		student = new Student();
		subject = new Subject();
		this.semester = semester;
	}
}