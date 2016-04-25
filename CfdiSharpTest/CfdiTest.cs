using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CfdiSharp.Complementos.donat11;
using CfdiSharp.Comprobante;
using CfdiSharp.src.Comprobante;
using CfdiSharp.Util;
using CfdiSharpTest.Edicom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CfdiSharpTest
{
    [TestClass]
    public class CfdiTest
    {
        [TestMethod]
        public void TestCreateCfdi()
        {
            var comp = CfdiCreator.CreateComprobante();
            CfdiCreator.SetSello(comp);

            Assert.IsTrue(Util.Validador.Validar(comp));
            //var xml = comp.ToString();
            //Util.WriteToFile(xml, @"C:\Users\user\Desktop\cfdi_test.xml", false);
            //Console.WriteLine(Util.Validador.UltimoMensaje);
        }


        [TestMethod]
        public void TestTimbrarCfdi()
        {
            var comp = CfdiCreator.CreateComprobante();
            //SetDonatarias(comp);
            CfdiCreator.SetSello(comp);

            var xml = comp.ToString();

            var file = Encoding.UTF8.GetBytes(xml);
            var timbrado = new CFDiClient();

            try
            {
                timbrado.getCfdiTest("", "", file);
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    
        
    }
}
