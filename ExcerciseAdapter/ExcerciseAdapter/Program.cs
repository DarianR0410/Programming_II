
using ExcerciseAdapter;

class Program
{
    static void Main()
    {
        IReloj reloj;
        
        Console.WriteLine("=== Sistema de Relojes ===");
        Console.WriteLine("Elija el tipo de reloj.");
        Console.WriteLine("[1] Reloj Digital || [2] Reloj Analogico.");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
            reloj = new RelojDigital();
        else
            reloj = new RelojAnalogicoAdapter();

        
        Pantalla pantalla = new Pantalla();
        pantalla.MostrarHora(reloj);
    }
}