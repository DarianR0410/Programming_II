using ExcerciseAdapter;

public class Pantalla
{
    public void MostrarHora(IReloj reloj)
    {
        string hora = reloj.ObtenerHoraActual();
        Console.WriteLine($"Hora actual: {hora}");
    }
}