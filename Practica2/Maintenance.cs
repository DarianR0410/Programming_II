namespace Practica2;

public class Maintenance
{
	public string Path = "C:\\Users\\Darian Ramos\\C#\\Practica2\\LogTracker\\Maintenance.txt";

	private Maintenance()
	{

	}

	private static Maintenance? _instance;

	public static Maintenance Instance()
	{
		if (_instance == null)
		{
			_instance = new Maintenance();
		}

		return _instance;
	}

	public string CleanSensor(string message)
	{
		TextWriter LogWriter = new StreamWriter(Path, true);
		
		LogWriter.WriteLine("Date: " + DateTime.Now + " Type: Clear of the sensor. " +  " Note: " + message);
		LogWriter.Close();
		
		return "Mantainance tracked.";

	}

	public string Calibration(string message)
	{
		TextWriter logWriter = new StreamWriter(Path, true);
		logWriter.WriteLine("Date: " + DateTime.Now + " Type: Calibration. " +  " Note: " + message);
		logWriter.Close();
		
		return "Calibration tracked.";
	}

	public string SensorReplacement(string message)
	{
		TextWriter logWriter = new StreamWriter(Path, true);
		logWriter.WriteLine("Date: " + DateTime.Now + " Type: Sensor replacement. " +  " Note: " + message);
		logWriter.Close();
		return "Sensor replacement tracked.";
	}

	public string GeneralReview(string message)
	{
		TextWriter logWriter = new StreamWriter(Path, true);
		logWriter.WriteLine("Date: " + DateTime.Now + " Type: Sensor replacement. " +  " Note: " + message);
		logWriter.Close();

		return "General review tracked";
	}
	
}