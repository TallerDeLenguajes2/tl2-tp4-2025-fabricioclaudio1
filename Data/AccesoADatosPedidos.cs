using System.Text.Json;
using tl2_tp4_2025_fabricioclaudio1.Models;
using tl2_tp4_2025_fabricioclaudio1.Services;

namespace tl2_tp4_2025_fabricioclaudio1.Data;

public class AccesoADatosPedidos
{
    public List<Pedido> Obtener() //json -> string -> objeto
    {
        const string pathPedido = "../Other/pedidos.json";
        string jsonDocument = HelperDeJson.LeerArchivoJson(pathPedido);
        var pedidos = JsonSerializer.Deserialize<List<Pedido>>(jsonDocument);

        return pedidos;
    }

    public void Guardar(List<Pedido> pedidos) //objeto -> string -> json
    {
        const string nombreArchivo = "../Other/pedidos.json";
        string pedidosJson = JsonSerializer.Serialize(pedidos);
        HelperDeJson.GuardarArchivoTexto(nombreArchivo, pedidosJson);
    }
}