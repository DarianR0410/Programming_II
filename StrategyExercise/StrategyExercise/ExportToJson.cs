using System.Text.Json;

namespace StrategyExercise;

public class ExportToJson : IFileExport
{
	string path = "C:\\Users\\Darian Ramos\\C#\\StrategyExercise\\StrategyExercise\\SaveInformation\\SaveInfo.json";
	public void SaveToFile( User user)
	{
		string jsonFile = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
		File.WriteAllText(path, jsonFile);
	}
}