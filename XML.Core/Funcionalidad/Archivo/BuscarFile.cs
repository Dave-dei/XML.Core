using System.IO;

namespace XML.Core.Funcionalidad.Archivo
{
    public static class BuscarFile
    {
        public static string Buscar(string rutaXML, string tipoArchivo)
        {
            string rutaRaiz = Path.GetDirectoryName(rutaXML);

            var archivo = Directory.GetFiles(rutaRaiz, tipoArchivo);
            return archivo?.Length > 0 ? archivo[0] : "";
        }
    }
}
