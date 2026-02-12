namespace tl2_tp4_2025_fabricioclaudio1.Models;

public class Cadeteria
{
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }

    public Cadeteria(string nombre, string telefono)
    {
        Nombre = nombre;

        Telefono = telefono;
    }
 


}