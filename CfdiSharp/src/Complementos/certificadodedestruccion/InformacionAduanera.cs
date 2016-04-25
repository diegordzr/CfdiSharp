using System.Xml.Serialization;

namespace CfdiSharp.Complementos.certificadodedestruccion
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/certificadodestruccion")]
    public class InformacionAduanera
    {
        [XmlAttribute("NumPedImp")]
        public string NumPedImp { get; set; }


        [XmlAttribute(DataType = "date")]
        public System.DateTime Fecha { get; set; }


        [XmlAttribute("Aduana")]
        public string Aduana { get; set; }
    }
}
