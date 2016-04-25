using System.Xml.Serialization;

namespace CfdiSharp.Complementos.AcreditamientoIEPS10
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/acreditamiento")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/acreditamiento", IsNullable = false)]
    public class AcreditamientoIeps
    {
        public AcreditamientoIeps()
        {
            Version = "1.0";
            SchemaLocation = "http://www.sat.gob.mx/acreditamiento http://www.sat.gob.mx/sitio_internet/cfd/acreditamiento/AcreditamientoIEPS10.xsd";
        }

        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }

        [XmlAttribute("Version")]
        public string Version { get; set; }


        [XmlAttribute("TAR")]
        public AcreditamientoIepsTar Tar { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.sat.gob.mx/acreditamiento")]
    public enum AcreditamientoIepsTar
    {


        [XmlEnum("617")]
        Item617,


        [XmlEnum("619")]
        Item619,


        [XmlEnum("624")]
        Item624,


        [XmlEnum("652")]
        Item652,


        [XmlEnum("654")]
        Item654,


        [XmlEnum("655")]
        Item655,


        [XmlEnum("656")]
        Item656,


        [XmlEnum("658")]
        Item658,


        [XmlEnum("659")]
        Item659,


        [XmlEnum("660")]
        Item660,


        [XmlEnum("661")]
        Item661,


        [XmlEnum("667")]
        Item667,


        [XmlEnum("693")]
        Item693,


        [XmlEnum("602")]
        Item602,


        [XmlEnum("603")]
        Item603,


        [XmlEnum("604")]
        Item604,


        [XmlEnum("605")]
        Item605,


        [XmlEnum("606")]
        Item606,


        [XmlEnum("607")]
        Item607,


        [XmlEnum("608")]
        Item608,


        [XmlEnum("609")]
        Item609,


        [XmlEnum("611")]
        Item611,


        [XmlEnum("612")]
        Item612,


        [XmlEnum("613")]
        Item613,


        [XmlEnum("614")]
        Item614,


        [XmlEnum("615")]
        Item615,


        [XmlEnum("620")]
        Item620,


        [XmlEnum("621")]
        Item621,


        [XmlEnum("622")]
        Item622,


        [XmlEnum("623")]
        Item623,


        [XmlEnum("625")]
        Item625,


        [XmlEnum("657")]
        Item657,


        [XmlEnum("664")]
        Item664,


        [XmlEnum("665")]
        Item665,


        [XmlEnum("666")]
        Item666,


        [XmlEnum("669")]
        Item669,


        [XmlEnum("695")]
        Item695,


        [XmlEnum("696")]
        Item696,


        [XmlEnum("697")]
        Item697,


        [XmlEnum("699")]
        Item699,


        [XmlEnum("627")]
        Item627,


        [XmlEnum("628")]
        Item628,


        [XmlEnum("629")]
        Item629,


        [XmlEnum("630")]
        Item630,


        [XmlEnum("631")]
        Item631,


        [XmlEnum("632")]
        Item632,


        [XmlEnum("633")]
        Item633,


        [XmlEnum("636")]
        Item636,


        [XmlEnum("637")]
        Item637,


        [XmlEnum("638")]
        Item638,


        [XmlEnum("639")]
        Item639,


        [XmlEnum("640")]
        Item640,


        [XmlEnum("641")]
        Item641,


        [XmlEnum("644")]
        Item644,


        [XmlEnum("645")]
        Item645,


        [XmlEnum("646")]
        Item646,


        [XmlEnum("647")]
        Item647,


        [XmlEnum("648")]
        Item648,


        [XmlEnum("649")]
        Item649,


        [XmlEnum("650")]
        Item650,


        [XmlEnum("663")]
        Item663,


        [XmlEnum("668")]
        Item668,


        [XmlEnum("672")]
        Item672,


        [XmlEnum("673")]
        Item673,


        [XmlEnum("674")]
        Item674,


        [XmlEnum("675")]
        Item675,


        [XmlEnum("676")]
        Item676,


        [XmlEnum("677")]
        Item677,


        [XmlEnum("678")]
        Item678,


        [XmlEnum("681")]
        Item681,


        [XmlEnum("682")]
        Item682,


        [XmlEnum("683")]
        Item683,


        [XmlEnum("684")]
        Item684,


        [XmlEnum("685")]
        Item685,


        [XmlEnum("688")]
        Item688,


        [XmlEnum("689")]
        Item689,


        [XmlEnum("690")]
        Item690,


        [XmlEnum("698")]
        Item698,
    }


}