
using tl2_tp4_2025_fabricioclaudio1.Models;

namespace tl2_tp4_2025_fabricioclaudio1.Services;

interface IAccesoADatos
{
    public Cadeteria CrearCadeteria(string pathCadeteria);
    public List<Cadete> ListaCedetes(string pathCadete);


}