using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{

    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class CuentaPredial
    {
        /// <comentarios/>
        [XmlAttribute("numero")]
        public string Numero { get; set; }
    }
}
