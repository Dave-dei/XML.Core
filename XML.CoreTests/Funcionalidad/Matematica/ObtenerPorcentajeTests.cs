using Microsoft.VisualStudio.TestTools.UnitTesting;

using XML.Core.Funcionalidad.Matematica;

namespace ValidadorSerPlaTec.Funcionalidad.Matematica.Tests
{
    [TestClass()]
    public class ObtenerPorcentajeTests
    {
        [TestMethod()]
        public void CalcularTest()
        {
            decimal value = ObtenerPorcentaje.Calcular("150.50", 50);
            Assert.AreEqual(value, 75.25M);
        }
    }
}