public class RelojAnalogico
{
    private int _hora;
    private int _minutos;
    private int _segundos;

    public RelojAnalogico(int hora, int minutos, int segundos)
    {
        _hora = hora;
        _minutos = minutos;
        _segundos = segundos;
    }

    public int ObtenerHora() => _hora;
    public int ObtenerMinutos() => _minutos;
    public int ObtenerSegundos() => _segundos;
}