using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ecb
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ecb")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/ecb", IsNullable = false)]
    public class EstadoDeCuentaBancario
    {
        public EstadoDeCuentaBancario()
        {
            this.Version = "1.0";
        }


        [XmlArrayItem("MovimientoECB", typeof(MovimientoEcb), IsNullable = false)]
        [XmlArrayItem("MovimientoECBFiscal", typeof(MovimientoEcbFiscal), IsNullable = false)]
        public object[] Movimientos { get; set; }


        [XmlAttribute("version")]
        public string Version { get; set; }


        [XmlAttribute(DataType = "integer")]
        public string NumeroCuenta { get; set; }


        [XmlAttribute("nombreCliente")]
        public string NombreCliente { get; set; }


        [XmlAttribute("periodo")]
        public string Periodo { get; set; }


        [XmlAttribute("sucursal")]
        public string Sucursal { get; set; }
    }
}