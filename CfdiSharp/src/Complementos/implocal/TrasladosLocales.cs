
using System.Xml.Serialization;

namespace CfdiSharp.Complementos.implocal
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/implocal")]
    public class TrasladosLocales
    {
        [XmlAttribute("ImpLocTrasladado")]
        public string ImpLocTrasladado { get; set; }


        [XmlAttribute("TasadeTraslado")]
        public decimal TasadeTraslado { get; set; }


        [XmlAttribute("Importe")]
        public decimal Importe { get; set; }
    }
}