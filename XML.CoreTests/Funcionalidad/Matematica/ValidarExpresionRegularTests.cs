using Microsoft.VisualStudio.TestTools.UnitTesting;

using XML.Core.Funcionalidad.Matematica;

namespace ValidadorSerPlaTec.Funcionalidad.Matematica.Tests
{
    [TestClass()]
    public class ValidarExpresionRegularTests
    {
        [TestMethod()]
        public void ValidarTest()
        {
            bool resultado = ValidarExpresionRegular.Validar("(([0][2-6]|[0][89])|([1][0-4]|[1][6-9])|([2][0-9]))D([^<>|]{0,16})", "02D");
            Assert.IsTrue(resultado);
        }
        [TestMethod()]
        public void ValidarErrorTest()
        {
            bool resultado = ValidarExpresionRegular.Validar("(([0][2-6]|[0][89])|([1][0-4]|[1][6-9])|([2][0-9]))D([^<>|]{0,16})", "15D");
            Assert.IsTrue(!resultado);
        }
    }
}