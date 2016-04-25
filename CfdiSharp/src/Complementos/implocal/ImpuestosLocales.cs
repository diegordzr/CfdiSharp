using System.Xml.Serialization;

namespace CfdiSharp.Complementos.implocal
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/implocal")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/implocal", IsNullable = false)]
    public class ImpuestosLocales
    {
        public ImpuestosLocales()
        {
            this.Version = "1.0";
        }


        [XmlElement("RetencionesLocales")]
        public RetencionesLocales[] RetencionesLocales { get; set; }


        [XmlElement("TrasladosLocales")]
        public TrasladosLocales[] TrasladosLocales { get; set; }


        [XmlAttribute("version")]
        public string Version { get; set; }


        [XmlAttribute("TotaldeRetenciones")]
        public decimal TotaldeRetenciones { get; set; }


        [XmlAttribute("TotaldeTraslados")]
        public decimal TotaldeTraslados { get; set; }
    }

}