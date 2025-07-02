namespace ExcerciseAdapter;

public class RelojAnalogicoAdapter : IReloj
{
	public RelojAnalogico _relojAnalogico;
	public string ObtenerHoraActual()
	{
		Console.WriteLine("Ingrese su hora actual:");
		int Hora = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Los minutos:");
		int Minutos = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Y los segundos:");
		int Segundos = Convert.ToInt32(Console.ReadLine());
		
		_relojAnalogico = new RelojAnalogico(Hora, Minutos, Segundos);
		
		return $"{_relojAnalogico.ObtenerHora()}:{_relojAnalogico.ObtenerMinutos()}:{_relojAnalogico.ObtenerSegundos()}";
	}
	
	
}