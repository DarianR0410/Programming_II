namespace StudentFactory;

public class CsvExport : IExport
{
	
	public void Export(Student student)
	{
		string path = "C:\\Users\\Darian Ramos\\C#\\StudentFactory\\StudentFactory\\SavedData\\CSVSaver.csv";
	
		TextWriter writer = new StreamWriter(path, true);
		writer.WriteLine("****************************************");
		writer.WriteLine("Student ID: " + student.CollegeId + " Name: " + student.Name + " Career: " + student.Career);
		writer.WriteLine("****************************************");
		writer.Close();
	}
}