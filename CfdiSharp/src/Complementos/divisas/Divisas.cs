using System.Xml.Serialization;

namespace CfdiSharp.Complementos.divisas
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/divisas")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/divisas", IsNullable = false)]
    public class Divisas
    {
        public Divisas()
        {
            this.Version = "1.0";
        }


        [XmlAttribute("version")]
        public string Version { get; set; }


        [XmlAttribute("tipoOperacion")]
        public DivisasTipoOperacion TipoOperacion { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/divisas")]
    public enum DivisasTipoOperacion
    {

        [XmlEnum("compra")]
        Compra,

        [XmlEnum("venta")]
        Venta,
    }
}