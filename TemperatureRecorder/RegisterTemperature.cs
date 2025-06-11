namespace TemperatureRecorder;

public class RegisterTemperature
{
	private List<Temperature> temperatures;
	private string path = "C:\\Users\\Darian Ramos\\C#\\TemperatureRecorder\\Recorder\\temperature.txt";
	
	public RegisterTemperature()
	{
		temperatures = new List<Temperature>();
	}

	public void TemperatureTracker(Temperature temperature)
	{
		TextWriter writer = new StreamWriter(path, true);
		writer.WriteLine("Date: " + temperature.Date + " Temperature: " + temperature.TempCelcius + " C.");
		writer.Close();
		if(temperature.TempCelcius > 0 && temperature.Date != null)
			temperatures.Add(temperature);
	}

	public void CheckTemperatureLog()
	{
		TextReader reader = new StreamReader(path);
		Console.WriteLine(reader.ReadToEnd());
		reader.Close();
	}
}