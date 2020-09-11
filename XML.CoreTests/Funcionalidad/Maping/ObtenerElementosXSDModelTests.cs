using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.Maping.Tests
{
    [TestClass()]
    public class ObtenerElementosXSDModelTests
    {
        [TestMethod()]
        public void MapearAdBOCGenTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "AdBOCGen.xsd");
            MapearXSD model = new MapearXSD(XDocument.Load(archivo));

            var resultado = model.Mapear();

            Assert.IsTrue(resultado.Error == null);
        }
        [TestMethod()]
        public void MapearAdSHBCHTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "AdSHBCH.xsd");
            MapearXSD model = new MapearXSD(XDocument.Load(archivo));

            var resultado = model.Mapear();

            Assert.IsTrue(resultado.Error == null);
        }
        [TestMethod()]
        public void MapearAdSHBCredTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "AdSHBCred.xsd");
            MapearXSD model = new MapearXSD(XDocument.Load(archivo));

            var resultado = model.Mapear();

            Assert.IsTrue(resultado.Error == null);
        }
        [TestMethod()]
        public void MapearAdSHBFXTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "AdSHBFX.xsd");
            MapearXSD model = new MapearXSD(XDocument.Load(archivo));

            var resultado = model.Mapear();

            Assert.IsTrue(resultado.Error == null);
        }
        [TestMethod()]
        public void MapearAdSHBInvTest()
        {
            string archivo = Path.Combine(Directory.GetCurrentDirectory(), "AdSHBInv.xsd");
            MapearXSD model = new MapearXSD(XDocument.Load(archivo));

            var resultado = model.Mapear();

            Assert.IsTrue(resultado.Error == null);
        }
        
    }
}