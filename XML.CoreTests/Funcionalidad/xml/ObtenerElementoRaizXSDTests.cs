using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.xml.Tests
{
    [TestClass()]
    public class ObtenerElementoRaizXSDTests
    {
        [TestMethod()]
        public void IniciarAsyncTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "AdBOCGen.xsd");
            var xml = XDocument.Load(archivo);

            CargarXSDNodo obtener = new CargarXSDNodo(xml);
            obtener.IniciarAsync();
            Assert.IsTrue(true);
        }
    }
}