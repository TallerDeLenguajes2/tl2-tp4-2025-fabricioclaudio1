namespace tl2_tp4_2025_fabricioclaudio1.Models;

public class Cadeteria
{
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }
    public List<Cadete>? Cadetes { get; set; } = new List<Cadete>();
    public List<Pedido>? Pedidos { get; set; } = new List<Pedido>();

    public Cadeteria(string nombre, string telefono)
    {
        Nombre = nombre;

        Telefono = telefono;
    }
    
    public float JornalACobrar(int idCadete)
    {
        Cadete? cadete = Cadetes.FirstOrDefault(c => c.Id == idCadete);
        int pedidosRealizados =  Pedidos.Count(p => p.Cadete == cadete && p.Estado == false);

        return pedidosRealizados * 500;
    }

    public bool AsignarCadeteAPedido(int idCadete, int idPedido)
    {
        if (Cadetes != null && Pedidos != null)
        {
            Pedidos.FirstOrDefault(p => p.NumeroPedido == idPedido).Cadete = Cadetes.FirstOrDefault(c => c.Id == idCadete);

            return true;
        }
        else
        {
            return false;
        }
    }

}