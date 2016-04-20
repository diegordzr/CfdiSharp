using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{
    public class RegimenFiscal
    {
        /// <comentarios/>
        [XmlAttribute()]
        public string Regimen { get; set; }
    }
}
