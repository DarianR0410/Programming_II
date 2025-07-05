using System.Text.Json;

namespace StudentFactory;

public class JsonExport : IExport
{
	private string path = "C:\\Users\\Darian Ramos\\C#\\StudentFactory\\StudentFactory\\SavedData\\JsonSaver.json";
	

	public void Export(Student student)
	{
		
		string jsonFile = JsonSerializer.Serialize(student, new JsonSerializerOptions { WriteIndented = true });
		File.WriteAllText(path, jsonFile);
	}
}