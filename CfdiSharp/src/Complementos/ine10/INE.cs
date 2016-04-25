using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ine10
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ine")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/ine", IsNullable = false)]
    public class Ine
    {
        public Ine()
        {
            Version = "1.0";
        }


        [XmlElement("Entidad")]
        public Entidad[] Entidad { get; set; }


        [XmlAttribute("Version")]
        public string Version { get; set; }


        [XmlAttribute("TipoProceso")]
        public TipoProceso TipoProceso { get; set; }


        [XmlAttribute("TipoComite")]
        public TipoComite TipoComite { get; set; }


        [XmlIgnore()]
        public bool TipoComiteSpecified { get; set; }


        [XmlAttribute("IdContabilidad")]
        public int IdContabilidad { get; set; }


        [XmlIgnore()]
        public bool IdContabilidadSpecified { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ine")]
    public class Entidad
    {
        [XmlElement("Contabilidad")]
        public Contabilidad[] Contabilidad { get; set; }


        [XmlAttribute("ClaveEntidad")]
        public ClaveEntidad ClaveEntidad { get; set; }


        [XmlAttribute("Ambito")]
        public Ambito Ambito { get; set; }


        [XmlIgnore()]
        public bool AmbitoSpecified { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ine")]
    public class Contabilidad
    {
        [XmlAttribute("IdContabilidad")]
        public int IdContabilidad { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.sat.gob.mx/ine")]
    public enum ClaveEntidad
    {

        [XmlEnum("AGU")]
        Agu,

        [XmlEnum("BCN")]
        Bcn,

        [XmlEnum("BCS")]
        Bcs,

        [XmlEnum("CAM")]
        Cam,

        [XmlEnum("CHP")]
        Chp,

        [XmlEnum("CHH")]
        Chh,

        [XmlEnum("COA")]
        Coa,

        [XmlEnum("COL")]
        Col,

        [XmlEnum("DIF")]
        Dif,

        [XmlEnum("DUR")]
        Dur,

        [XmlEnum("GUA")]
        Gua,

        [XmlEnum("GRO")]
        Gro,

        [XmlEnum("HID")]
        Hid,

        [XmlEnum("JAL")]
        Jal,

        [XmlEnum("MEX")]
        Mex,

        [XmlEnum("MIC")]
        Mic,

        [XmlEnum("MOR")]
        Mor,

        [XmlEnum("NAY")]
        Nay,

        [XmlEnum("NLE")]
        Nle,

        [XmlEnum("OAX")]
        Oax,

        [XmlEnum("PUE")]
        Pue,

        [XmlEnum("QTO")]
        Qto,

        [XmlEnum("ROO")]
        Roo,

        [XmlEnum("SLP")]
        Slp,

        [XmlEnum("SIN")]
        Sin,

        [XmlEnum("SON")]
        Son,

        [XmlEnum("TAB")]
        Tab,

        [XmlEnum("TAM")]
        Tam,

        [XmlEnum("TLA")]
        Tla,

        [XmlEnum("VER")]
        Ver,

        [XmlEnum("YUC")]
        Yuc,

        [XmlEnum("ZAC")]
        Zac,
    }


    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.sat.gob.mx/ine")]
    public enum Ambito
    {

        [XmlEnum("Local")]
        Local,

        [XmlEnum("Federal")]
        Federal,
    }


    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.sat.gob.mx/ine")]
    public enum TipoProceso
    {

        [XmlEnum("Ordinario")]
        Ordinario,

        [XmlEnum("Precampaña")]
        Precampaña,

        [XmlEnum("Campaña")]
        Campaña,
    }


    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.sat.gob.mx/ine")]
    public enum TipoComite
    {


        [XmlEnum("Ejecutivo Nacional")]
        EjecutivoNacional,


        [XmlEnum("Ejecutivo Estatal")]
        EjecutivoEstatal,
    }
}