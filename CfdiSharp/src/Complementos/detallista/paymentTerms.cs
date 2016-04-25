using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class PaymentTerms
    {
        public PaymentTermsNetPayment NetPayment { get; set; }


        public PaymentTermsDiscountPayment DiscountPayment { get; set; }


        [XmlAttribute("paymentTermsEvent")]
        public PaymentTermsPaymentTermsEvent PaymentTermsEvent { get; set; }


        [XmlIgnore()]
        public bool PaymentTermsEventSpecified { get; set; }


        [XmlAttribute("PaymentTermsRelationTime")]
        public PaymentTermsPaymentTermsRelationTime PaymentTermsRelationTime { get; set; }


        [XmlIgnore()]
        public bool PaymentTermsRelationTimeSpecified { get; set; }
    }
}