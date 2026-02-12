
using System.Text.Json;
using tl2_tp4_2025_fabricioclaudio1.Models;
using tl2_tp4_2025_fabricioclaudio1.Services;

namespace tl2_tp4_2025_fabricioclaudio1.Data;

public class AccesoADatosCadeteria
{
    public Cadeteria Obtener()
    {
        const string pathCadeteria = "../Other/cadeteria.json";
        string jsonDocument = HelperDeJson.LeerArchivoJson(pathCadeteria);
        var cadeteria = JsonSerializer.Deserialize<Cadeteria>(jsonDocument);

        return cadeteria;
    }
}