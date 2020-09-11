using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XML.Core.Funcionalidad.Async
{
    /// <summary>
    /// Los procesos Async son funcionales mientras sean en su mismo contexto, si los métodos del Nuget se vuelven Async
    /// estos dejan de funcionar ya que el proceso de carga de datos XML no responde, este efecto se ve al cargar el Nuget
    /// en un nuevo proyecto.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct EsperarTareasAsync<T>
    {
        public async Task<List<T>> ValidarAsync(List<Task<T>> tareas)
        {
            List<T> lstNodos = new List<T>();

            while (tareas?.Any() == true)
            {
                Task<T> Nodo = await Task.WhenAny(tareas);

                lstNodos.Add(Nodo.Result);
                tareas.Remove(Nodo);
            }

            return lstNodos;
        }
    }
}
