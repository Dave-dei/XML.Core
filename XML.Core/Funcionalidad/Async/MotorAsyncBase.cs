using Framework.Interfaz;
using System.Threading.Tasks;

namespace XML.Core.Funcionalidad.Async
{
    public struct MotorAsyncBase
    {
        public async Task<T> EjecutarProcesoAsync<T>(IEjecutarProcessAsync<T> metodoXML) => await Task.Run(() => metodoXML.IniciarAsync());
    }
}
