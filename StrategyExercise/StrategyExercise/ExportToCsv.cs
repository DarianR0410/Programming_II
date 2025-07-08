namespace StrategyExercise;

public class ExportToCsv : IFileExport
{
	string path = "C:\\Users\\Darian Ramos\\C#\\StrategyExercise\\StrategyExercise\\SaveInformation\\SaveInfo.csv";
	
	public void SaveToFile(User user)
	{
		TextWriter writer = new StreamWriter(path, true);
		writer.WriteLine("Name" + user.Name + " Age: " + user.Age + " Email: " + user.Email);
		writer.Close();
	}
}