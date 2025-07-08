namespace AdapterExcercise;

public class SensorAdapter : ISensor
{
	private PressureSensor Sensor { get; set; }
	public decimal Pressure { get; set; }

	public SensorAdapter()
	{
		Sensor = new PressureSensor();
		Pressure = Sensor.Pressure;
	}
	
	public string MeteorologicalMessage(string message)
	{
		Sensor.Pressure = Pressure;
		Sensor.Sensor(Pressure);
		return "The temperature is " + message + " and the current pressure is: " + Sensor.Sensor(Pressure);
	}
}