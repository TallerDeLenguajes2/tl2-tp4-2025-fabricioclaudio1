namespace tl2_tp4_2025_fabricioclaudio1.Services;

public static class HelperDeJson
{

    public static string LeerArchivoJson(string nombreArchivo)
    {
        using (var strReader = new StreamReader(nombreArchivo))
        {
            return strReader.ReadToEnd();
        }

        
    }

    public static void GuardarArchivoTexto(string nombreArchivo, string datos)
    {
        using (var strWriter = new StreamWriter(nombreArchivo))
        {
            strWriter.WriteLine("{0}", datos);
        }

    }
}

