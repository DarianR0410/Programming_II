using ExcerciseAdapter;

public class RelojDigital : IReloj
{
    public string ObtenerHoraActual()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }
}