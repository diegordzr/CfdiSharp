using System.Xml.Serialization;

namespace CfdiSharp.Complementos.TuristaPasajeroExtranjero
{

    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TuristaPasajeroExtranjero")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/TuristaPasajeroExtranjero", IsNullable = false)]
    public class TuristaPasajeroExtranjero
    {
        public TuristaPasajeroExtranjero()
        {
            this.Version = "1.0";
        }


        public DatosTransito DatosTransito { get; set; }


        [XmlAttribute("version")]
        public string Version { get; set; }


        [XmlAttribute()]
        public System.DateTime FechadeTransito { get; set; }


        [XmlAttribute("tipoTransito")]
        public TuristaPasajeroExtranjeroTipoTransito TipoTransito { get; set; }
    }



    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TuristaPasajeroExtranjero")]
    public enum TuristaPasajeroExtranjeroDatosTransitoVia
    {

        [XmlEnum("Aérea")]
        Aérea,

        [XmlEnum("Marítima")]
        Marítima,

        [XmlEnum("Terrestre")]
        Terrestre,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TuristaPasajeroExtranjero")]
    public enum TuristaPasajeroExtranjeroTipoTransito
    {

        [XmlEnum("Arribo")]
        Arribo,

        [XmlEnum("Salida")]
        Salida,
    }


}