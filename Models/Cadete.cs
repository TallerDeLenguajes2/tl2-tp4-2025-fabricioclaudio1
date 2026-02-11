using System.ComponentModel;

namespace EspacioCadeteria;


public class Cadete
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }


    public Cadete(string nombre, string direccion, string telefono)
    {
        Nombre = nombre;

        Direccion = direccion;

        Telefono = telefono;
    }

}