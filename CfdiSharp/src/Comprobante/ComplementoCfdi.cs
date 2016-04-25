using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{
    public abstract class ComplementoCfdi
    {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
    }
}
