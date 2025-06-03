namespace SubjectRegistration.Repositories;

public class SubjectRepository
{
	private List<Subject> subjects;
	
	

	public SubjectRepository()
	{
		subjects = new List<Subject>();
	}

	public Subject AddSubject(Subject subject)
	{
		if (subject == null || string.IsNullOrEmpty(subject.code) || string.IsNullOrEmpty(subject.name) ||
		    subject.credits == 0 || string.IsNullOrEmpty(subject.professor) || subject.time == default)
			throw new ArgumentException("Invalid data provided. Check all fields correctly.");
		
			subjects.Add(subject);
			
			return subject;
	}

	public Subject SelectSubjectByCode(Subject subject, string code)
	{
		if (subject.code == null || string.IsNullOrEmpty(code))
			throw new ArgumentException("Unable to select or find the subject. Check the code provided and try again.");

		for (int i = 0; i < subjects.Count; i++)
		{
			if (subject.capacity == 0 && subjects[i].code == code)
			{
				subject = subjects[i];
				subjects[i].capacity -= 1;
				if (subjects[i].capacity == 0)
					throw new ArgumentException("This subject has reached its capacity, please select another session.");

				return subject;
			}
		}
		return null;
	}
	

	public Subject RemoveSubject(Subject subject, string code)
	{
		for (int i = 0; i < subjects.Count; i++)
		{
			if (subjects[i].code == code)
			{
				subjects.RemoveAt(i);
				return subject;
			}
		}

		return null;
	}

	public Subject GetSubject(Subject subject, string code)
	{
		for (int i = 0; i < subjects.Count; i++)
		{
			if (subjects[i].code == code)
			{
				subject = subjects[i];
				return subject;
			}
		}

		return null;
	}

	public List<Subject> GetListOfSubjects()
	{
		if (subjects == null || subjects.Count == 0)
			throw new InvalidOperationException("No subjects have been found");	
			
		return subjects;
	}


	

}