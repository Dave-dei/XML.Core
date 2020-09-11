
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

using XML.Core.Data.Model;

namespace XML.Core.Funcionalidad.Maping.Tests
{
    [TestClass()]
    public class ObtenerDependenciasVisualStudioModelTests
    {
        [TestMethod()]
        public void ObtenerModeloTest()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\TFS\PAC.Adicionales5.0\Feature\PAC.EmisionBatch_2020-023.1");
            StringBuilder texto = new StringBuilder();
            List<VisualStudioModel> lstresultado = new List<VisualStudioModel>();

            //string resultadofinal = "";

            foreach (var item in di.GetFiles("*.csproj", SearchOption.AllDirectories))
            {
                var pack = item.Directory.GetFiles("*packages.config");
                MapearVisualStudio modelo = new MapearVisualStudio(XDocument.Load(item.FullName), item.FullName);

                lstresultado.Add(modelo.Mapear());
            }


            Assert.IsTrue(!lstresultado.Exists(i => i.Error != null));
        }
        [TestMethod()]
        public void ObtenerModelo2Test()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\TFS\PAC.Adicionales5.0\Feature\PAC.EmisionBatch_2020-023.1");
            StringBuilder texto = new StringBuilder();
            List<VisualStudioModel> lstresultado = new List<VisualStudioModel>();
            //string resultadofinal = "";

            foreach (var item in di.GetFiles("*.csproj", SearchOption.AllDirectories))
            {
                MapearVisualStudio modelo = new MapearVisualStudio(XDocument.Load(item.FullName), item.FullName);
                lstresultado.Add(modelo.Mapear());
            }

            Assert.IsTrue(!lstresultado.Exists(i => i.Error != null));
        }


    }
}