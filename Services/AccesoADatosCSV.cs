using tl2_tp4_2025_fabricioclaudio1.Models;

namespace tl2_tp4_2025_fabricioclaudio1.Services;

public class AccesoADatosCSV : IAccesoADatos
{
    public Cadeteria CrearCadeteria(string pathCadeteriaCSV)
    {

        //Leo cadeteria.csv y creo un objeto con sus datos
        using (var lector = new StreamReader(pathCadeteriaCSV))
        {

            if (!lector.EndOfStream)
            {
                // Leer línea por línea
                var linea = lector.ReadLine();

                // Separar por comas
                var valores = linea.Split(',');

                // Recorrer los valores de cada columna
                var nombre = valores[0];
                var telefono = valores[1];

                //Creo cadeteria
                return new Cadeteria(nombre, telefono);
            }

        }
        return null;
    }

    public List<Cadete> ListaCedetes(string pathCadeteCSV)
    {
        //Leo cadete.csv y creo varios objetos con sus datos
        using (var lector = new StreamReader(pathCadeteCSV))
        {
            List<Cadete> listaCadetes = [];
            while (!lector.EndOfStream)
            {
                // Leer línea por línea
                var linea = lector.ReadLine();

                // Separar por comas
                var valores = linea.Split(',');

                // Recorrer los valores de cada columna
                listaCadetes.Add(new Cadete(valores[0], valores[1], valores[2]));
            }

            //Agrego id
            int id = 0;
            foreach (var cadete in listaCadetes)
            {
                cadete.Id = id + 1;
                id++;
            }
            return listaCadetes;
        }
    }

}