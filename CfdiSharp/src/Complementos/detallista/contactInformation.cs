using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class ContactInformation
    {
        public PersonOrDepartmentName PersonOrDepartmentName { get; set; }
    }
}