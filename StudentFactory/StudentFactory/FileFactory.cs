namespace StudentFactory;

public class FileFactory
{
	private Student Student { get; set; }

	public FileFactory(Student student)
	{
		Student = student;
	}
	public IExport CreateExport(int option, Student student)
	{
		if (option == 1)
		{
			JsonExport jsonExport = new JsonExport();
			jsonExport.Export(student);
			
		}

		if (option == 2)
		{
			TextExport textExport = new TextExport();
			textExport.Export(student);
		}
		else
		{
			CsvExport csvExport = new CsvExport();
			csvExport.Export(student);
		}

		return null;
	}
}