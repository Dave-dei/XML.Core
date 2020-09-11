using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.Maping.Tests
{
    [TestClass()]
    public class ObtenerServiciosPlataformasTecnologicasModelTests
    {
        [TestMethod()]
        public void ObtenerModeloTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "OK_ServiciosPlataformasTec");
            MapearServiciosPlataformasTecnologicas model = new MapearServiciosPlataformasTecnologicas(XDocument.Load(archivo));
            var resultado = model.Mapear();

            Assert.IsTrue(resultado.Error == null);
        }
    }
}