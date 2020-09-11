using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.xml.Tests
{
    [TestClass()]
    public class BuscarElementosXMLTests
    {
        [TestMethod()]
        public void BuscarTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "AdBOCGen.xsd");
            var xml = XDocument.Load(archivo);
            var elemento = BuscarElementosXML.Buscar(xml);

            Assert.IsTrue(elemento != null);
        }
    }
}