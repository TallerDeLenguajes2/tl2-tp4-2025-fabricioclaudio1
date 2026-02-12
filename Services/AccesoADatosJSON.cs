using System.Text.Json;
using tl2_tp4_2025_fabricioclaudio1.Models;
namespace tl2_tp4_2025_fabricioclaudio1.Services;



public class AccesoADatosJSON : IAccesoADatos
{
    public Cadeteria CrearCadeteria(string pathCadeteria)
    {
        string jsonDocument = HelperDeJson.LeerArchivoJson(pathCadeteria);
        var productosRecuperados = JsonSerializer.Deserialize<Cadeteria>(jsonDocument);

        return productosRecuperados;
    }

    public List<Cadete> ListaCedetes(string pathCadete)
    {
        string jsonDocument = HelperDeJson.LeerArchivoJson(pathCadete);
        return JsonSerializer.Deserialize<List<Cadete>>(jsonDocument);
    }
}