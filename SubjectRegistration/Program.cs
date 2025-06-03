namespace SubjectRegistration;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		SubjectRegistration subjectRegistration = new SubjectRegistration();
		

		while (isRunning)
		{
			Console.WriteLine("WELCOME TO THE SUBJECT REGISTRATION SYSTEM!");
			Console.WriteLine("1- Register as a student.");
			Console.WriteLine("2- Select subjects.");
			Console.WriteLine("3- Check your schedule.");
			Console.WriteLine("4- Remove a subject from your schedule.");
			Console.WriteLine("5- Add Subjects to the system.");
			Console.WriteLine("6- Exit the system.");
			int option = Convert.ToInt32(Console.ReadLine());

			switch (option)
			{
				case 1:
					Console.WriteLine("WELCOME TO THE NEW SEMESTER!");
					Console.WriteLine("To select a subject, please register as a student. Please provide the following information:");
					Console.Write("Name: ");
					string name = Console.ReadLine();
					Console.Write("Last name:");
					string lastName = Console.ReadLine();
					Console.Write("ID:");
					int id = Convert.ToInt32(Console.ReadLine());
					Console.Write("institutional email:");
					string institutionalEmail = Console.ReadLine();
					Console.Write("What's your career?");
					string career = Console.ReadLine(); // Let's assume software engineering/development bc the subjects I added are from this career.
					Student student = new Student {name = name, lastName = lastName, id = id, InstitutionEmail = institutionalEmail, career = career};
					if (student != null)
					{
						subjectRegistration.RegisterStudent(student);
						Console.WriteLine("Welcome back" + student.name + " you have succesfully registered for the selection of this semester's subjects.");
					}
					else
					{
						throw new ArgumentException("There is invalid or missing data, please try again.");
					}
					break;
				case 2:
					Console.WriteLine("WELCOME TO THE SUBJECT SELECTION!");
					Console.WriteLine("Please select the subjects you want to register for this semester.");
					Console.WriteLine("Please choose one of the following subjects:");
					subjectRegistration.GetAvailableSubjects();
					Console.Write("What's the class you would like to take in this semester?");
					string classname = Console.ReadLine();
					Console.Write("What's the code of the subject you would like to take?");
					string code = Console.ReadLine();
					Subject subject = new Subject { name = classname, code = code };
					if (subject.code == code)
					{
						subjectRegistration.SelectSubject(subject, code);
						Console.WriteLine("You have successfully selected the subject " + subject.name + " with code " + subject.code + ".");
					}
					else
					{
						throw new ArgumentException("Invalid subject code, please try again.");
					}
					break;
				case 3: Console.WriteLine("WELCOME TO YOUR SCHEDULE!");
					Console.WriteLine("Please provide your ID to look for your schedule.");
					int studentId = Convert.ToInt32(Console.ReadLine());
					Student studentSchedule = new Student { id = studentId };
					if (studentSchedule.id == studentId)
					{
						subjectRegistration.GetSchedule(studentSchedule);
					}
					else
					{
						throw new ArgumentException("Unable to find an schedule under this ID.");
					}
					break;
				case 4: Console.WriteLine("WELCOME TO THE SUBJECT SELECTION!");
					Console.WriteLine("It seems you would like to remove one of your subjects, to proceed please provide the following information:");
					Console.Write("Please provide the code of the subject you want to remove:");
					string subjectCode = Console.ReadLine();
					Subject subjectToRemove = new Subject { code = subjectCode };
					if (subjectToRemove.code == subjectCode)
					{
						subjectRegistration.UnregisterSubject(subjectToRemove, subjectCode);
						Console.WriteLine("You have successfully removed the subject with code " + subjectToRemove.code + " from your schedule.");
					}
					else
					{
						throw new ArgumentException("Invalid subject code, please try again.");
					}
					
					break;
				case 5: Console.WriteLine("WELCOME TO THE SUBJECT REGISTRATION SYSTEM!");
					Console.WriteLine("Please provide the following information to add a subject to the system:");
					Console.Write("Name of the subject: ");
					string subjectName = Console.ReadLine();
					Console.Write("Code of the subject: ");
					string subjectCodeToAdd = Console.ReadLine();
					Console.Write("Credits of the subject: ");
					int credits = Convert.ToInt32(Console.ReadLine());
					Console.Write("Professor of the subject: ");
					string professor = Console.ReadLine();
					Console.Write("Time of the subject (format: yyyy-mm-dd): ");
					DateTime time = Convert.ToDateTime(Console.ReadLine());
					Console.Write("Capacity of the subject: ");
					int capacity = Convert.ToInt32(Console.ReadLine());
					Subject newSubject = new Subject { name = subjectName, code = subjectCodeToAdd, credits = credits, professor = professor, time = time, capacity = capacity };
					if (newSubject != null)
					{
						subjectRegistration.RegisterSubject(newSubject);
						Console.WriteLine("The subject " + newSubject.name + " with code " + newSubject.code + " has been successfully added to the system.");
					}
					else
					{
						throw new ArgumentException("There is invalid or missing data, please try again.");
					}
					
					break;
				case 6: isRunning = false;
					break;
				default: Console.WriteLine("The option provided is invalid, please try again.");
					break;
			}

		}
	}
}