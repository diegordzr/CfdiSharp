using CfdiSharp.Complementos.donat11;
using CfdiSharp.Comprobante;
using CfdiSharp.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CfdiSharpTest
{
    [TestClass]
    public class DonatariasTest
    {
        private static void SetDonatarias(Comprobante comp)
        {
            comp.Complemento = new Complemento();
            var donatarias = new Donatarias();
            donatarias.Leyenda = "Hola";
            donatarias.NoAutorizacion = "1234";


            comp.Complemento.Any = new ComplementoCfdi[] { donatarias };
            
        }

        [TestMethod]
        public void TestDonatarias()
        {
            var comp = CfdiCreator.CreateComprobante();
            SetDonatarias(comp);
            CfdiCreator.SetSello(comp);

            Assert.IsTrue(Util.Validador.Validar(comp));
        }
    }
}
