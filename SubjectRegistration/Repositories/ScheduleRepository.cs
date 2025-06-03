namespace SubjectRegistration.Repositories;

public class ScheduleRepository
{
	private List<Schedule> schedules;
	
	
	public ScheduleRepository()
	{
		schedules = new List<Schedule>();
	}

	public Schedule AddSchedule(Student student, string semester, List<Subject> subjects)
	{
		
		if (student == null || string.IsNullOrEmpty(semester) || 
		    subjects == null || subjects.Count == 0)
			throw new ArgumentException("SOMETHING WENT WRONG, Check all fields and try again.");
		
		Schedule newSchedule = new Schedule { student = student, semester = semester, subjects = subjects, subject = subjects.FirstOrDefault() };
    
		schedules.Add(newSchedule);
		return newSchedule;
	}

	public Schedule RemoveSchedule(Schedule schedule, string semester, int studentId)
	{
		if (schedules == null || schedules.Count == 0)
			return null;

		for (int i = 0; i < schedules.Count; i++)
		{
			if (schedule.semester == semester && schedule.student.id == studentId)
			{
				schedule = schedules[i];
				return schedule;
			}
		}
		return null;
	}

	public Schedule CheckScheduleById(Student student)
	{
		if (student.id == 0)
			return null;

		foreach (Schedule schedule in schedules)
		{
			if (schedule.student.id == student.id)
			{
				return schedule;
			}
		}
		return null;
	}


}