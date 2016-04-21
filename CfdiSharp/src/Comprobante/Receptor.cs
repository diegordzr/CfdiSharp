using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{
    public class Receptor
    {
        /// <comentarios/>
        public Domicilio Domicilio { get; set; }

        /// <comentarios/>
        [XmlAttribute("rfc")]
        public string Rfc { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("nombre")]
        public string Nombre { get; set; }
    }
}
