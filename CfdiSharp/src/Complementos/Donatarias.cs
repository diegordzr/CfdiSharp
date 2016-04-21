using System;
using System.Xml.Serialization;
using CfdiSharp.Comprobante;

namespace CfdiSharp.Complementos
{
    public class Donatarias
    {
        public Donatarias()
        {
            Version = "1.1";
            SchemaLocation = "http://www.sat.gob.mx/donat http://www.sat.gob.mx/sitio_internet/cfd/donat/donat11.xsd";
        }

        [XmlAttributeAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlAttribute("noAutorizacion")]
        public string NoAutorizacion { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "fechaAutorizacion")]
        public System.DateTime FechaAutorizacion { get; set; }

        [XmlAttribute("leyenda")]
        public string Leyenda { get; set; }
    }

}
