namespace SubjectRegistration.Repositories;

public class StudentRepository
{
	private List<Student> students;

	public StudentRepository()
	{
		students = new List<Student>();
	}

	public Student AddStudent(Student student)
	{
		if (student == null || string.IsNullOrEmpty(student.name) || string.IsNullOrEmpty(student.lastName) ||
		    student.id <= 0 || string.IsNullOrEmpty(student.InstitutionEmail) || string.IsNullOrEmpty(student.career))
		{
			throw new ArgumentException("Invalid student data provided."); 
			
		} 
		
		students.Add(student);
		return student;
	}

	public Student RemoveStudent(Student student, int id)
	{
		for (int i = 0; i < students.Count; i++)
		{
			if (students[i].id == id)
			{
				student = students[i];
				students.RemoveAt(i);
				return student;
			}
		}
		return null;
	}

	public Student GetStudent(Student student, int id)
	{
		for (int i = 0; i < students.Count; i++)
		{
			if (students[i].id == id)
			{
				student = students[i];
				return student;
			}
		}

		return null;
	}

	public List<Student> GetLisOfStudents()
	{
		if (students == null || students.Count == 0)
			throw new InvalidOperationException("No students found.");
			
		return students;
	}
}