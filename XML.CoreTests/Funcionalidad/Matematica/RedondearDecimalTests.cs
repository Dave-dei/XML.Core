using Microsoft.VisualStudio.TestTools.UnitTesting;

using XML.Core.Funcionalidad.Matematica;

namespace ValidadorSerPlaTec.Funcionalidad.Matematica.Tests
{
    [TestClass()]
    public class RedondearDecimalTests
    {
        [TestMethod()]
        public void RedondearTest()
        {
            decimal resultado = TruncarDecimales.Obtener2("100.0156");
            Assert.AreEqual(resultado, 100.01M);
        }
    }
}