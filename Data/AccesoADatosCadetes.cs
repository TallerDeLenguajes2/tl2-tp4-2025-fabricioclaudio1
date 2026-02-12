using System.Text.Json;
using tl2_tp4_2025_fabricioclaudio1.Models;
using tl2_tp4_2025_fabricioclaudio1.Services;

namespace tl2_tp4_2025_fabricioclaudio1.Data;


public class AccesoADatosCadetes
{
    public List<Cadete> Obtener()
    {
        const string pathCadete = "../Other/cadete.json";
        string jsonDocument = HelperDeJson.LeerArchivoJson(pathCadete);
        var cadete = JsonSerializer.Deserialize<List<Cadete>>(jsonDocument);

        return cadete;
    }

    
}