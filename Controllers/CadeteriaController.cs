using Microsoft.AspNetCore.Mvc;
using tl2_tp4_2025_fabricioclaudio1.Models;

namespace tl2_tp4_2025_fabricioclaudio1.Controllers;

[ApiController]
[Route("[controller]")]
public class CadeteriaController : ControllerBase
{

    public CadeteriaController()
    {
        
    }

    [HttpGet]
    public List<Pedido> GetPedido()
    {
        List<Pedido> lista = new List<Pedido>();

        return lista;
    }

    [HttpGet]
    public List<Cadete> GetCadete()
    {
        List<Cadete> lista = new List<Cadete>();

        return lista;
    }

    [HttpGet]
    public List<Informe> GetInforme()
    {
        List<Informe> lista = new List<Informe>();

        return lista;
    }

    [HttpPost]
    public bool AgregarPedido(Pedido pedido)
    {

        return false;
    }

    [HttpPut]
    public bool AsignarPedido(int idPedido, int idCadete)
    {
        return false;
    }

    [HttpPut]
    public bool CambiarEstadoPedido(int idPedido, int NuevoEstado)
    {
        return false;
    }

    [HttpPut]
    public bool CambiarCadetePedido(int idPedido, int idNuevoCadete)
    {
        return false;
    }

}