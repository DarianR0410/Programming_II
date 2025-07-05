namespace StudentFactory;

public class TextExport : IExport
{
	private string path = "C:\\Users\\Darian Ramos\\C#\\StudentFactory\\StudentFactory\\SavedData\\TextSaver";
	
	public void Export(Student student)
	{
		TextWriter writer = new StreamWriter(path, true);
		writer.WriteLine("****************************************");
		writer.WriteLine("Student ID: " + student.CollegeId + " Name: " + student.Name + " Career: " + student.Career);
		writer.WriteLine("****************************************");
		writer.Close();
	}
}