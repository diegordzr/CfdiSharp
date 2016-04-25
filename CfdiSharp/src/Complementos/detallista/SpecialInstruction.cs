using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class SpecialInstruction
    {
        [XmlElement("text")]
        public string[] text { get; set; }


        [XmlText()]
        public string[] Text { get; set; }


        [XmlAttribute("code")]
        public SpecialInstructionCode Code { get; set; }
    }
}
