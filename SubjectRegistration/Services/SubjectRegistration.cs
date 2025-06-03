using SubjectRegistration.Repositories;

namespace SubjectRegistration;

public class SubjectRegistration
{
	
	public StudentRepository studentRepository { get; set; }
	public SubjectRepository subjectRepository { get; set; }
	
	public ScheduleRepository scheduleRepository { get; set; }

	public SubjectRegistration()
	{
		studentRepository = new StudentRepository();
		subjectRepository = new SubjectRepository();
		scheduleRepository = new ScheduleRepository();
	}

	public void RegisterStudent(Student student)
	{
		studentRepository.AddStudent(student);
	}

	public void UnregisterStudent(Student student, int id)
	{
		studentRepository.RemoveStudent(student, id);
	}

	public void LookUpStudent(Student student, int id)
	{
		studentRepository.GetStudent(student, id);
	}
	
	public void RegisterSubject(Subject subject)
	{
		subjectRepository.AddSubject(subject);
	}
	
	public void UnregisterSubject(Subject subject, string code)
	{
		subjectRepository.RemoveSubject(subject, code);
	}
	
	public void LookUpSubjectByCode(Subject subject, string code)
	{
		subjectRepository.GetSubject(subject, code);
	}

	public void SelectSubject(Subject subject, string code)
	{
		subjectRepository.SelectSubjectByCode(subject, code);
	}

	public void GetSchedule(Student student)
	{
		scheduleRepository.CheckScheduleById(student);
	}
	
	public void CreateSchedule(Student student, string semester, List<Subject> subjects)
	{
		scheduleRepository.AddSchedule(student, semester, subjects);
	}
	
	public void GetAvailableSubjects()
	{
		 subjectRepository.GetListOfSubjects();
	}

	public void GetRegisteredStudents()
	{ 
		studentRepository.GetLisOfStudents();

	}
	
}