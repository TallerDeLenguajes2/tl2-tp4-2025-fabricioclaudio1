namespace tl2_tp4_2025_fabricioclaudio1.Models;

public class Pedido
{
    public int NumeroPedido { get; set; }
    public string? Observaciones { get; set; }
    public Cliente? Cliente { get; set; }
    public bool Estado { get; set; }
    public Cadete? Cadete { get; set; }

    public Pedido(int numeroPedido, string obs, Cliente cliente, bool estado)
    {
        NumeroPedido = numeroPedido;
        Observaciones = obs;
        Cliente = cliente;
        Estado = estado;
    }

}