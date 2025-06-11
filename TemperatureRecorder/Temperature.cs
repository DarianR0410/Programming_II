namespace TemperatureRecorder;

public class Temperature
{
	public DateTime Date { get; set; }
	public double TempCelcius { get; set; }

	public Temperature()
	{
		Date = DateTime.Now;
		this.TempCelcius = TempCelcius;
	}
	
}