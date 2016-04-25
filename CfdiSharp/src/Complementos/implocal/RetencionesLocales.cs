
using System.Xml.Serialization;

namespace CfdiSharp.Complementos.implocal
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/implocal")]
    public class RetencionesLocales
    {
        [XmlAttribute("ImpLocRetenido")]
        public string ImpLocRetenido { get; set; }


        [XmlAttribute("TasadeRetencion")]
        public decimal TasadeRetencion { get; set; }


        [XmlAttribute("Importe")]
        public decimal Importe { get; set; }
    }
}