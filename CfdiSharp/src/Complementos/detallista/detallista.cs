using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/detallista", IsNullable = false)]
    public class Detallista
    {
        public Detallista()
        {
            Type = "SimpleInvoiceType";
            ContentVersion = "1.3.1";
            DocumentStructureVersion = "AMC8.1";
        }


        public RequestForPaymentIdentification RequestForPaymentIdentification { get; set; }


        [XmlElement("specialInstruction")]
        public SpecialInstruction[] SpecialInstruction { get; set; }


        public OrderIdentification OrderIdentification { get; set; }


        [XmlArrayItem("referenceIdentification", IsNullable = false)]
        public ReferenceIdentification[] AdditionalInformation { get; set; }


        public DeliveryNote DeliveryNote { get; set; }


        public Buyer Buyer { get; set; }


        public Seller Seller { get; set; }


        public ShipTo ShipTo { get; set; }


        public InvoiceCreator InvoiceCreator { get; set; }


        [XmlElement("Customs")]
        public Customs[] Customs { get; set; }


        [XmlElement("currency")]
        public Currency[] Currency { get; set; }


        public PaymentTerms PaymentTerms { get; set; }


        public ShipmentDetail ShipmentDetail { get; set; }


        [XmlElement("allowanceCharge")]
        public AllowanceCharge[] AllowanceCharge { get; set; }


        [XmlElement("lineItem")]
        public LineItem[] LineItem { get; set; }


        public TotalAmount TotalAmount { get; set; }


        [XmlElement("TotalAllowanceCharge")]
        public TotalAllowanceCharge[] TotalAllowanceCharge { get; set; }


        [XmlAttribute("type")]
        public string Type { get; set; }


        [XmlAttribute("contentVersion")]
        public string ContentVersion { get; set; }


        [XmlAttribute("documentStructureVersion")]
        public string DocumentStructureVersion { get; set; }


        [XmlAttribute("documentStatus")]
        public DocumentStatus DocumentStatus { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum RequestForPaymentIdentificationEntityType
    {

        [XmlEnum("INVOICE")]
        Invoice,

        [XmlEnum("DEBIT_NOTE")]
        DebitNote,

        [XmlEnum("CREDIT_NOTE")]
        CreditNote,

        [XmlEnum("LEASE_RECEIPT")]
        LeaseReceipt,

        [XmlEnum("HONORARY_RECEIPT")]
        HonoraryReceipt,

        [XmlEnum("_INVOICE")]
        _INVOICE,

        [XmlEnum("TRANSPORT_DOCUMENT")]
        TransportDocument,

        [XmlEnum("AUTO_INVOICE")]
        AutoInvoice,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum SpecialInstructionCode
    {

        [XmlEnum("AAB")]
        Aab,

        [XmlEnum("DUT")]
        Dut,

        [XmlEnum("PUR")]
        Pur,

        [XmlEnum("ZZZ")]
        Zzz,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum OrderIdentificationReferenceIdentificationType
    {

        [XmlEnum("ON")]
        On,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum ReferenceIdentificationType
    {

        [XmlEnum("AAE")]
        Aae,

        [XmlEnum("CK")]
        Ck,

        [XmlEnum("ACE")]
        Ace,

        [XmlEnum("ATZ")]
        Atz,

        [XmlEnum("DQ")]
        Dq,

        [XmlEnum("IV")]
        Iv,

        [XmlEnum("ON")]
        On,

        [XmlEnum("AWR")]
        Awr,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum SellerAlternatePartyIdentificationType
    {

        [XmlEnum("SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY")]
        SellerAssignedIdentifierForAParty,

        [XmlEnum("IEPS_REFERENCE")]
        IepsReference,
    }

    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum InvoiceCreatorAlternatePartyIdentificationType
    {

        [XmlEnum("VA")]
        Va,

        [XmlEnum("IA")]
        Ia,
    }

    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum CurrencyCurrencyFunction
    {

        [XmlEnum("BILLING_CURRENCY")]
        BillingCurrency,

        [XmlEnum("PRICE_CURRENCY")]
        PriceCurrency,

        [XmlEnum("PAYMENT_CURRENCY")]
        PaymentCurrency,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum CurrencyCurrencyIsoCode
    {

        [XmlEnum("MXN")]
        Mxn,

        [XmlEnum("XEU")]
        Xeu,

        [XmlEnum("USD")]
        Usd,
    }

    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum PaymentTermsNetPaymentPaymentTimePeriodTimePeriodDueTimePeriod
    {

        [XmlEnum("DAYS")]
        Days,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum PaymentTermsNetPaymentNetPaymentTermsType
    {

        [XmlEnum("BASIC_NET")]
        BasicNet,

        [XmlEnum("END_OF_MONTH")]
        EndOfMonth,

        [XmlEnum("BASIC_DISCOUNT_OFFERED")]
        BasicDiscountOffered,
    }

    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum PaymentTermsDiscountPaymentDiscountType
    {

        [XmlEnum("ALLOWANCE_BY_PAYMENT_ON_TIME")]
        AllowanceByPaymentOnTime,

        [XmlEnum("SANCTION")]
        Sanction,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum PaymentTermsPaymentTermsEvent
    {

        [XmlEnum("DATE_OF_INVOICE")]
        DateOfInvoice,

        [XmlEnum("EFFECTIVE_DATE")]
        EffectiveDate,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum PaymentTermsPaymentTermsRelationTime
    {

        [XmlEnum("REFERENCE_AFTER")]
        ReferenceAfter,
    }

    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum AllowanceChargeSpecialServicesType
    {

        [XmlEnum("AA")]
        Aa,

        [XmlEnum("AJ")]
        Aj,

        [XmlEnum("ADO")]
        Ado,

        [XmlEnum("ADT")]
        Adt,

        [XmlEnum("ADS")]
        Ads,

        [XmlEnum("ABZ")]
        Abz,

        [XmlEnum("DA")]
        Da,

        [XmlEnum("EAA")]
        Eaa,

        [XmlEnum("EAB")]
        Eab,

        [XmlEnum("PI")]
        Pi,

        [XmlEnum("TAE")]
        Tae,

        [XmlEnum("SAB")]
        Sab,

        [XmlEnum("RAA")]
        Raa,

        [XmlEnum("PAD")]
        Pad,

        [XmlEnum("FG")]
        Fg,

        [XmlEnum("FA")]
        Fa,

        [XmlEnum("TD")]
        Td,

        [XmlEnum("TS")]
        Ts,

        [XmlEnum("TX")]
        Tx,

        [XmlEnum("TZ")]
        Tz,

        [XmlEnum("ZZZ")]
        Zzz,

        [XmlEnum("VAB")]
        Vab,

        [XmlEnum("UM")]
        Um,

        [XmlEnum("DI")]
        Di,

        [XmlEnum("CAC")]
        Cac,

        [XmlEnum("COD")]
        Cod,

        [XmlEnum("EAB")]
        Eab1,

        [XmlEnum("FC")]
        Fc,

        [XmlEnum("FI")]
        Fi,

        [XmlEnum("HD")]
        Hd,

        [XmlEnum("QD")]
        Qd,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum AllowanceChargeMonetaryAmountOrPercentageRateBase
    {

        [XmlEnum("INVOICE_VALUE")]
        InvoiceValue,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum AllowanceChargeAllowanceChargeType
    {

        [XmlEnum("ALLOWANCE_GLOBAL")]
        AllowanceGlobal,

        [XmlEnum("CHARGE_GLOBAL")]
        ChargeGlobal,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum AllowanceChargeSettlementType
    {

        [XmlEnum("BILL_BACK")]
        BillBack,

        [XmlEnum("OFF_INVOICE")]
        OffInvoice,
    }

    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemAlternateTradeItemIdentificationType
    {

        [XmlEnum("BUYER_ASSIGNED")]
        BuyerAssigned,

        [XmlEnum("SUPPLIER_ASSIGNED")]
        SupplierAssigned,

        [XmlEnum("SERIAL_NUMBER")]
        SerialNumber,

        [XmlEnum("GLOBAL_TRADE_ITEM_IDENTIFICATION")]
        GlobalTradeItemIdentification,
    }

    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemTradeItemDescriptionInformationLanguage
    {

        [XmlEnum("ES")]
        Es,

        [XmlEnum("EN")]
        En,
    }







    


   


   




    


   


    


    





   


   

    


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class PaymentTermsNetPayment
    {
        public PaymentTermsNetPaymentPaymentTimePeriod PaymentTimePeriod { get; set; }


        [XmlAttribute("netPaymentTermsType")]
        public PaymentTermsNetPaymentNetPaymentTermsType NetPaymentTermsType { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class PaymentTermsNetPaymentPaymentTimePeriod
    {
        public PaymentTermsNetPaymentPaymentTimePeriodTimePeriodDue TimePeriodDue { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class PaymentTermsNetPaymentPaymentTimePeriodTimePeriodDue
    {
        public string Value { get; set; }


        [XmlAttribute("timePeriod")]
        public PaymentTermsNetPaymentPaymentTimePeriodTimePeriodDueTimePeriod TimePeriod { get; set; }
    }  


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class PaymentTermsDiscountPayment
    {
        public string Percentage { get; set; }


        [XmlAttribute("discountType")]
        public PaymentTermsDiscountPaymentDiscountType DiscountType { get; set; }
    }



    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class ShipmentDetail
    {
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class AllowanceCharge
    {
        public AllowanceChargeSpecialServicesType SpecialServicesType { get; set; }


        [XmlIgnore()]
        public bool SpecialServicesTypeSpecified { get; set; }


        public AllowanceChargeMonetaryAmountOrPercentage MonetaryAmountOrPercentage { get; set; }


        [XmlAttribute("allowanceChargeType")]
        public AllowanceChargeAllowanceChargeType AllowanceChargeType { get; set; }


        [XmlAttribute("settlementType")]
        public AllowanceChargeSettlementType SettlementType { get; set; }


        [XmlAttribute("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class AllowanceChargeMonetaryAmountOrPercentage
    {
        public AllowanceChargeMonetaryAmountOrPercentageRate Rate { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class AllowanceChargeMonetaryAmountOrPercentageRate
    {
        public decimal Percentage { get; set; }


        [XmlAttribute("@base")]
        public AllowanceChargeMonetaryAmountOrPercentageRateBase Base { get; set; }
    }



    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItem
    {
        public LineItem()
        {
            Type = "SimpleInvoiceLineItemType";
        }


        public LineItemTradeItemIdentification TradeItemIdentification { get; set; }


        [XmlElement("alternateTradeItemIdentification")]
        public LineItemAlternateTradeItemIdentification[] AlternateTradeItemIdentification { get; set; }


        public LineItemTradeItemDescriptionInformation TradeItemDescriptionInformation { get; set; }


        public LineItemInvoicedQuantity InvoicedQuantity { get; set; }


        [XmlElement("aditionalQuantity")]
        public LineItemAditionalQuantity[] AditionalQuantity { get; set; }


        public LineItemGrossPrice GrossPrice { get; set; }


        public LineItemNetPrice NetPrice { get; set; }


        public LineItemAdditionalInformation AdditionalInformation { get; set; }


        [XmlElement("Customs")]
        public LineItemCustoms[] Customs { get; set; }


        public LineItemLogisticUnits LogisticUnits { get; set; }


        public LineItemPalletInformation PalletInformation { get; set; }


        [XmlArrayItem("lotNumber", IsNullable = false)]
        public LineItemLotNumber[] ExtendedAttributes { get; set; }


        [XmlElement("allowanceCharge")]
        public LineItemAllowanceCharge[] AllowanceCharge { get; set; }


        [XmlElement("tradeItemTaxInformation")]
        public LineItemTradeItemTaxInformation[] TradeItemTaxInformation { get; set; }


        public LineItemTotalLineAmount TotalLineAmount { get; set; }


        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("SimpleInvoiceLineItemType")]
        public string Type { get; set; }


        [XmlAttribute(DataType = "integer")]
        public string Number { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemTradeItemIdentification
    {
        public string Gtin { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemAlternateTradeItemIdentification
    {
        [XmlAttribute("type")]
        public LineItemAlternateTradeItemIdentificationType Type { get; set; }


        [XmlText()]
        public string[] Text { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemTradeItemDescriptionInformation
    {
        public string LongText { get; set; }


        [XmlAttribute("language")]
        public LineItemTradeItemDescriptionInformationLanguage Language { get; set; }


        [XmlIgnore()]
        public bool LanguageSpecified { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemInvoicedQuantity
    {
        [XmlAttribute(DataType = "NMTOKEN")]
        public string UnitOfMeasure { get; set; }


        [XmlText()]
        public string[] Text { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemAditionalQuantity
    {
        [XmlAttribute("QuantityType")]
        public LineItemAditionalQuantityQuantityType QuantityType { get; set; }


        [XmlText()]
        public string[] Text { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemAditionalQuantityQuantityType
    {

        [XmlEnum("NUM_CONSUMER_UNITS")]
        NumConsumerUnits,

        [XmlEnum("FREE_GOODS")]
        FreeGoods,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemGrossPrice
    {
        public decimal Amount { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemNetPrice
    {
        public decimal Amount { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemAdditionalInformation
    {
        public LineItemAdditionalInformationReferenceIdentification ReferenceIdentification { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemAdditionalInformationReferenceIdentification
    {
        [XmlAttribute("type")]
        public LineItemAdditionalInformationReferenceIdentificationType Type { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemAdditionalInformationReferenceIdentificationType
    {

        [XmlEnum("ON")]
        On,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemCustoms
    {
        public string Gln { get; set; }


        public LineItemCustomsAlternatePartyIdentification AlternatePartyIdentification { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime ReferenceDate { get; set; }


        public LineItemCustomsNameAndAddress NameAndAddress { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemCustomsAlternatePartyIdentification
    {
        [XmlAttribute("type")]
        public LineItemCustomsAlternatePartyIdentificationType Type { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemCustomsAlternatePartyIdentificationType
    {

        [XmlEnum("TN")]
        Tn,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemCustomsNameAndAddress
    {
        public string Name { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemLogisticUnits
    {
        public LineItemLogisticUnitsSerialShippingContainerCode SerialShippingContainerCode { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemLogisticUnitsSerialShippingContainerCode
    {
        [XmlAttribute("type")]
        public LineItemLogisticUnitsSerialShippingContainerCodeType Type { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemLogisticUnitsSerialShippingContainerCodeType
    {

        [XmlEnum("BJ")]
        Bj,

        [XmlEnum("SRV")]
        Srv,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemPalletInformation
    {
        public string PalletQuantity { get; set; }


        public LineItemPalletInformationDescription Description { get; set; }


        public LineItemPalletInformationTransport Transport { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemPalletInformationDescription
    {
        [XmlAttribute("type")]
        public LineItemPalletInformationDescriptionType Type { get; set; }


        [XmlText()]
        public string[] Text { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemPalletInformationDescriptionType
    {

        [XmlEnum("EXCHANGE_PALLETS")]
        ExchangePallets,

        [XmlEnum("RETURN_PALLETS")]
        ReturnPallets,

        [XmlEnum("PALLET_80x100")]
        Pallet80X100,

        [XmlEnum("CASE")]
        Case,

        [XmlEnum("BOX")]
        Box,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemPalletInformationTransport
    {
        public LineItemPalletInformationTransportMethodOfPayment MethodOfPayment { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemPalletInformationTransportMethodOfPayment
    {

        [XmlEnum("PREPAID_BY_SELLER")]
        PrepaidBySeller,

        [XmlEnum("PAID_BY_BUYER")]
        PaidByBuyer,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemLotNumber
    {
        [XmlAttribute(DataType = "date")]
        public System.DateTime ProductionDate { get; set; }


        [XmlIgnore()]
        public bool ProductionDateSpecified { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemAllowanceCharge
    {
        public LineItemAllowanceChargeSpecialServicesType SpecialServicesType { get; set; }


        [XmlIgnore()]
        public bool SpecialServicesTypeSpecified { get; set; }


        public LineItemAllowanceChargeMonetaryAmountOrPercentage MonetaryAmountOrPercentage { get; set; }


        [XmlAttribute("allowanceChargeType")]
        public LineItemAllowanceChargeAllowanceChargeType AllowanceChargeType { get; set; }


        [XmlAttribute("settlementType")]
        public LineItemAllowanceChargeSettlementType SettlementType { get; set; }


        [XmlIgnore()]
        public bool SettlementTypeSpecified { get; set; }


        [XmlAttribute("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemAllowanceChargeSpecialServicesType
    {

        [XmlEnum("AA")]
        Aa,

        [XmlEnum("ADS")]
        Ads,

        [XmlEnum("ADO")]
        Ado,

        [XmlEnum("ABZ")]
        Abz,

        [XmlEnum("DA")]
        Da,

        [XmlEnum("EAA")]
        Eaa,

        [XmlEnum("PI")]
        Pi,

        [XmlEnum("TAE")]
        Tae,

        [XmlEnum("SAB")]
        Sab,

        [XmlEnum("RAA")]
        Raa,

        [XmlEnum("PAD")]
        Pad,

        [XmlEnum("FG")]
        Fg,

        [XmlEnum("FA")]
        Fa,

        [XmlEnum("TD")]
        Td,

        [XmlEnum("TS")]
        Ts,

        [XmlEnum("TX")]
        Tx,

        [XmlEnum("ZZZ")]
        Zzz,

        [XmlEnum("VAB")]
        Vab,

        [XmlEnum("UM")]
        Um,

        [XmlEnum("DI")]
        Di,

        [XmlEnum("ADT")]
        Adt,

        [XmlEnum("AJ")]
        Aj,

        [XmlEnum("CAC")]
        Cac,

        [XmlEnum("COD")]
        Cod,

        [XmlEnum("EAB")]
        Eab,

        [XmlEnum("FC")]
        Fc,

        [XmlEnum("FI")]
        Fi,

        [XmlEnum("HD")]
        Hd,

        [XmlEnum("QD")]
        Qd,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemAllowanceChargeMonetaryAmountOrPercentage
    {
        public string PercentagePerUnit { get; set; }


        public LineItemAllowanceChargeMonetaryAmountOrPercentageRatePerUnit RatePerUnit { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemAllowanceChargeMonetaryAmountOrPercentageRatePerUnit
    {
        public string AmountPerUnit { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemAllowanceChargeAllowanceChargeType
    {

        [XmlEnum("ALLOWANCE_GLOBAL")]
        AllowanceGlobal,

        [XmlEnum("CHARGE_GLOBAL")]
        ChargeGlobal,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemAllowanceChargeSettlementType
    {

        [XmlEnum("OFF_INVOICE")]
        OffInvoice,

        [XmlEnum("CHARGE_TO_BE_PAID_BY_VENDOR")]
        ChargeToBePaidByVendor,

        [XmlEnum("CHARGE_TO_BE_PAID_BY_CUSTOMER")]
        ChargeToBePaidByCustomer,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemTradeItemTaxInformation
    {
        public LineItemTradeItemTaxInformationTaxTypeDescription TaxTypeDescription { get; set; }


        public string ReferenceNumber { get; set; }


        public LineItemTradeItemTaxInformationTradeItemTaxAmount TradeItemTaxAmount { get; set; }


        public LineItemTradeItemTaxInformationTaxCategory TaxCategory { get; set; }


        [XmlIgnore()]
        public bool TaxCategorySpecified { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemTradeItemTaxInformationTaxTypeDescription
    {

        [XmlEnum("GST")]
        Gst,

        [XmlEnum("VAT")]
        Vat,

        [XmlEnum("LAC")]
        Lac,

        [XmlEnum("AAA")]
        Aaa,

        [XmlEnum("ADD")]
        Add,

        [XmlEnum("FRE")]
        Fre,

        [XmlEnum("LOC")]
        Loc,

        [XmlEnum("STT")]
        Stt,

        [XmlEnum("OTH")]
        Oth,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemTradeItemTaxInformationTradeItemTaxAmount
    {
        public decimal TaxPercentage { get; set; }


        public decimal TaxAmount { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum LineItemTradeItemTaxInformationTaxCategory
    {

        [XmlEnum("TRANSFERIDO")]
        Transferido,

        [XmlEnum("RETENIDO")]
        Retenido,
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemTotalLineAmount
    {
        public LineItemTotalLineAmountGrossAmount GrossAmount { get; set; }


        public LineItemTotalLineAmountNetAmount NetAmount { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemTotalLineAmountGrossAmount
    {
        public decimal Amount { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class LineItemTotalLineAmountNetAmount
    {
        public decimal Amount { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class TotalAmount
    {
        public decimal Amount { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class TotalAllowanceCharge
    {
        public TotalAllowanceChargeSpecialServicesType SpecialServicesType { get; set; }


        [XmlIgnore()]
        public bool SpecialServicesTypeSpecified { get; set; }


        public decimal Amount { get; set; }


        [XmlIgnore()]
        public bool AmountSpecified { get; set; }


        [XmlAttribute("allowanceOrChargeType")]
        public TotalAllowanceChargeAllowanceOrChargeType AllowanceOrChargeType { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum TotalAllowanceChargeSpecialServicesType
    {

        [XmlEnum("AA")]
        Aa,

        [XmlEnum("ADS")]
        Ads,

        [XmlEnum("ADO")]
        Ado,

        [XmlEnum("ABZ")]
        Abz,

        [XmlEnum("DA")]
        Da,

        [XmlEnum("EAA")]
        Eaa,

        [XmlEnum("PI")]
        Pi,

        [XmlEnum("TAE")]
        Tae,

        [XmlEnum("SAB")]
        Sab,

        [XmlEnum("RAA")]
        Raa,

        [XmlEnum("PAD")]
        Pad,

        [XmlEnum("FG")]
        Fg,

        [XmlEnum("FA")]
        Fa,

        [XmlEnum("TD")]
        Td,

        [XmlEnum("TS")]
        Ts,

        [XmlEnum("TX")]
        Tx,

        [XmlEnum("ZZZ")]
        Zzz,

        [XmlEnum("VAB")]
        Vab,

        [XmlEnum("UM")]
        Um,

        [XmlEnum("DI")]
        Di,

        [XmlEnum("ADT")]
        Adt,

        [XmlEnum("AJ")]
        Aj,

        [XmlEnum("CAC")]
        Cac,

        [XmlEnum("COD")]
        Cod,

        [XmlEnum("EAB")]
        Eab,

        [XmlEnum("FC")]
        Fc,

        [XmlEnum("FI")]
        Fi,

        [XmlEnum("HD")]
        Hd,

        [XmlEnum("QD")]
        Qd,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum TotalAllowanceChargeAllowanceOrChargeType
    {

        [XmlEnum("ALLOWANCE")]
        Allowance,

        [XmlEnum("CHARGE")]
        Charge,
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DocumentStatus
    {

        [XmlEnum("ORIGINAL")]
        Original,

        [XmlEnum("COPY")]
        Copy,

        [XmlEnum("REEMPLAZA")]
        Reemplaza,

        [XmlEnum("DELETE")]
        Delete,
    }
}