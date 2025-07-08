namespace AdapterExcercise;

public class TempSensor : ISensor
{
	
	public string MeteorologicalMessage(string message)
	{
		return "Today's temperature is: " + message;
	}
}