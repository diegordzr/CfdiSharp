using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    public class Detallista
    {
        public Detallista()
        {
            Type = "SimpleInvoiceType";
            ContentVersion = "1.3.1";
            DocumentStructureVersion = "AMC8.1";
        }
        /// 
        [XmlElement("requestForPaymentIdentification")]
        public DetallistaRequestForPaymentIdentification RequestForPaymentIdentification { get; set; }

        /// 
        [XmlElement("specialInstruction")]
        public DetallistaSpecialInstruction[] SpecialInstruction { get; set; }

        /// 
        [XmlElement("orderIdentification")]
        public DetallistaOrderIdentification OrderIdentification { get; set; }

        /// 
        [XmlArrayItemAttribute("referenceIdentification", IsNullable = false)]
        public DetallistaReferenceIdentification[] AdditionalInformation { get; set; }

        /// 
        [XmlElement("DeliveryNote")]
        public DetallistaDeliveryNote DeliveryNote { get; set; }

        /// 
        [XmlElement("buyer")]
        public DetallistaBuyer Buyer { get; set; }

        /// 
        [XmlElement("seller")]
        public DetallistaSeller Seller { get; set; }

        /// 
        [XmlElement("shipTo")]
        public DetallistaShipTo ShipTo { get; set; }

        /// 
        [XmlElement("InvoiceCreator")]
        public DetallistaInvoiceCreator InvoiceCreator { get; set; }

        /// 
        [XmlElementAttribute("Customs")]
        public DetallistaCustoms[] Customs { get; set; }

        /// 
        [XmlElementAttribute("currency")]
        public DetallistaCurrency[] Currency { get; set; }

        /// 
        [XmlElement("paymentTerms")]
        public DetallistaPaymentTerms PaymentTerms { get; set; }

        /// 
        [XmlElement("shipmentDetail")]
        public DetallistaShipmentDetail ShipmentDetail { get; set; }

        /// 
        [XmlElementAttribute("allowanceCharge")]
        public DetallistaAllowanceCharge[] AllowanceCharge { get; set; }

        /// 
        [XmlElementAttribute("lineItem")]
        public DetallistaLineItem[] LineItem { get; set; }

        /// 
        [XmlElement("totalAmount")]
        public DetallistaTotalAmount TotalAmount { get; set; }

        /// 
        [XmlElementAttribute("TotalAllowanceCharge")]
        public DetallistaTotalAllowanceCharge[] TotalAllowanceCharge { get; set; }

        /// 
        [XmlAttributeAttribute("type")]
        public string Type { get; set; }

        /// 
        [XmlAttributeAttribute("contentVersion")]
        public string ContentVersion { get; set; }

        /// 
        [XmlAttributeAttribute("documentStructureVersion")]
        public string DocumentStructureVersion { get; set; }

        /// 
        [XmlAttributeAttribute("documentStatus")]
        public DetallistaDocumentStatus DocumentStatus { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaRequestForPaymentIdentification
    {
        /// 
        [XmlElement("entityType")]
        public DetallistaRequestForPaymentIdentificationEntityType EntityType { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaSpecialInstruction
    {
        /// 
        [XmlElementAttribute("text")]
        public string[] Text { get; set; }

        /// 
        [XmlAttributeAttribute("code")]
        public DetallistaSpecialInstructionCode Code { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaOrderIdentification
    {
        /// 
        [XmlElementAttribute("referenceIdentification")]
        public DetallistaOrderIdentificationReferenceIdentification[] ReferenceIdentification { get; set; }

        /// 
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime ReferenceDate { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool ReferenceDateSpecified { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaOrderIdentificationReferenceIdentification
    {
        public DetallistaOrderIdentificationReferenceIdentification()
        {
            Type = DetallistaOrderIdentificationReferenceIdentificationType.On;
        }
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaOrderIdentificationReferenceIdentificationType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaReferenceIdentification
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaReferenceIdentificationType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaDeliveryNote
    {
        /// 
        [XmlElementAttribute("referenceIdentification")]
        public string[] ReferenceIdentification { get; set; }

        /// 
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime ReferenceDate { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool ReferenceDateSpecified { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaBuyer
    {
        /// 
        [XmlElement("gln")]
        public string Gln { get; set; }

        /// 
        [XmlElement("contactInformation")]
        public DetallistaBuyerContactInformation ContactInformation { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaBuyerContactInformation
    {
        /// 
        [XmlElement("personOrDepartmentName")]
        public DetallistaBuyerContactInformationPersonOrDepartmentName PersonOrDepartmentName { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaBuyerContactInformationPersonOrDepartmentName
    {
        /// 
        [XmlElement("text")]
        public string Text { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaSeller
    {
        /// 
        [XmlElement("gln")]
        public string Gln { get; set; }

        /// 
        [XmlElement("alternatePartyIdentification")]
        public DetallistaSellerAlternatePartyIdentification AlternatePartyIdentification { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaSellerAlternatePartyIdentification
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaSellerAlternatePartyIdentificationType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaShipTo
    {
        /// 
        [XmlElement("gln")]
        public string Gln { get; set; }

        /// 
        [XmlElement("nameAndAddress")]
        public DetallistaShipToNameAndAddress NameAndAddress { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaShipToNameAndAddress
    {
        /// 
        [XmlElementAttribute("name")]
        public string[] Name { get; set; }

        /// 
        [XmlElementAttribute("streetAddressOne")]
        public string[] StreetAddressOne { get; set; }

        /// 
        [XmlElementAttribute("city")]
        public string[] City { get; set; }

        /// 
        [XmlElementAttribute("postalCode")]
        public string[] PostalCode { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaInvoiceCreator
    {
        /// 
        [XmlElement("gln")]
        public string Gln { get; set; }

        /// 
        [XmlElement("alternatePartyIdentification")]
        public DetallistaInvoiceCreatorAlternatePartyIdentification AlternatePartyIdentification { get; set; }

        /// 
        [XmlElement("nameAndAddress")]
        public DetallistaInvoiceCreatorNameAndAddress NameAndAddress { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaInvoiceCreatorAlternatePartyIdentification
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaInvoiceCreatorAlternatePartyIdentificationType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaInvoiceCreatorNameAndAddress
    {
        /// 
        [XmlElement("name")]
        public string Name { get; set; }

        /// 
        [XmlElement("streetAddressOne")]
        public string StreetAddressOne { get; set; }

        /// 
        [XmlElement("city")]
        public string City { get; set; }

        /// 
        [XmlElement("postalCode")]
        public string PostalCode { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaCustoms
    {
        /// 
        [XmlElement("gln")]
        public string Gln { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaCurrency
    {
        /// 
        [XmlElementAttribute("currencyFunction")]
        public DetallistaCurrencyCurrencyFunction[] CurrencyFunction { get; set; }

        /// 
        [XmlElement("rateOfChange")]
        public decimal RateOfChange { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool RateOfChangeSpecified { get; set; }

        /// 
        [XmlAttributeAttribute("currencyISOCode")]
        public DetallistaCurrencyCurrencyIsoCode CurrencyIsoCode { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaPaymentTerms
    {
        /// 
        [XmlElement("netPayment")]
        public DetallistaPaymentTermsNetPayment NetPayment { get; set; }

        /// 
        [XmlElement("discountPayment")]
        public DetallistaPaymentTermsDiscountPayment DiscountPayment { get; set; }

        /// 
        [XmlAttributeAttribute("paymentTermsEvent")]
        public DetallistaPaymentTermsPaymentTermsEvent PaymentTermsEvent { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool PaymentTermsEventSpecified { get; set; }

        /// 
        [XmlAttributeAttribute("PaymentTermsRelationTime")]
        public DetallistaPaymentTermsPaymentTermsRelationTime PaymentTermsRelationTime { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool PaymentTermsRelationTimeSpecified { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaPaymentTermsNetPayment
    {
        /// 
        [XmlElement("paymentTimePeriod")]
        public DetallistaPaymentTermsNetPaymentPaymentTimePeriod PaymentTimePeriod { get; set; }

        /// 
        [XmlAttributeAttribute("netPaymentTermsType")]
        public DetallistaPaymentTermsNetPaymentNetPaymentTermsType NetPaymentTermsType { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaPaymentTermsNetPaymentPaymentTimePeriod
    {
        /// 
        [XmlElement("timePeriodDue")]
        public DetallistaPaymentTermsNetPaymentPaymentTimePeriodTimePeriodDue TimePeriodDue { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaPaymentTermsNetPaymentPaymentTimePeriodTimePeriodDue
    {
        /// 
        [XmlElement("value")]
        public string Value { get; set; }

        /// 
        [XmlAttributeAttribute("timePeriod")]
        public DetallistaPaymentTermsNetPaymentPaymentTimePeriodTimePeriodDueTimePeriod TimePeriod { get; set; }
    }

    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaPaymentTermsDiscountPayment
    {
        /// 
        [XmlElement("percentage")]
        public string Percentage { get; set; }

        /// 
        [XmlAttributeAttribute("discountType")]
        public DetallistaPaymentTermsDiscountPaymentDiscountType DiscountType { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaShipmentDetail
    {
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaAllowanceCharge
    {
        /// 
        [XmlElement("specialServicesType")]
        public DetallistaAllowanceChargeSpecialServicesType SpecialServicesType { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool SpecialServicesTypeSpecified { get; set; }

        /// 
        [XmlElement("monetaryAmountOrPercentage")]
        public DetallistaAllowanceChargeMonetaryAmountOrPercentage MonetaryAmountOrPercentage { get; set; }

        /// 
        [XmlAttributeAttribute("allowanceChargeType")]
        public DetallistaAllowanceChargeAllowanceChargeType AllowanceChargeType { get; set; }

        /// 
        [XmlAttributeAttribute("settlementType")]
        public DetallistaAllowanceChargeSettlementType SettlementType { get; set; }

        /// 
        [XmlAttributeAttribute("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaAllowanceChargeMonetaryAmountOrPercentage
    {
        /// 
        [XmlElement("rate")]
        public DetallistaAllowanceChargeMonetaryAmountOrPercentageRate Rate { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaAllowanceChargeMonetaryAmountOrPercentageRate
    {
        /// 
        [XmlElement("percentage")]
        public decimal Percentage { get; set; }

        /// 
        [XmlAttributeAttribute("@base")]
        public DetallistaAllowanceChargeMonetaryAmountOrPercentageRateBase Base { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItem
    {
        public DetallistaLineItem()
        {
            Type = "SimpleInvoiceLineItemType";
        }
        /// 
        [XmlElement("tradeItemIdentification")]
        public DetallistaLineItemTradeItemIdentification TradeItemIdentification { get; set; }

        /// 
        [XmlElementAttribute("alternateTradeItemIdentification")]
        public DetallistaLineItemAlternateTradeItemIdentification[] AlternateTradeItemIdentification { get; set; }

        /// 
        [XmlElement("tradeItemDescriptionInformation")]
        public DetallistaLineItemTradeItemDescriptionInformation TradeItemDescriptionInformation { get; set; }

        /// 
        [XmlElement("invoicedQuantity")]
        public DetallistaLineItemInvoicedQuantity InvoicedQuantity { get; set; }

        /// 
        [XmlElementAttribute("aditionalQuantity")]
        public DetallistaLineItemAditionalQuantity[] AditionalQuantity { get; set; }

        /// 
        [XmlElement("grossPrice")]
        public DetallistaLineItemGrossPrice GrossPrice { get; set; }

        /// 
        [XmlElement("netPrice")]
        public DetallistaLineItemNetPrice NetPrice { get; set; }

        /// 
        [XmlElement("AdditionalInformation")]
        public DetallistaLineItemAdditionalInformation AdditionalInformation { get; set; }

        /// 
        [XmlElementAttribute("Customs")]
        public DetallistaLineItemCustoms[] Customs { get; set; }

        /// 
        [XmlElement("LogisticUnits")]
        public DetallistaLineItemLogisticUnits LogisticUnits { get; set; }

        /// 
        [XmlElement("palletInformation")]
        public DetallistaLineItemPalletInformation PalletInformation { get; set; }

        /// 
        [XmlArrayItemAttribute("lotNumber", IsNullable = false)]
        public DetallistaLineItemLotNumber[] ExtendedAttributes { get; set; }

        /// 
        [XmlElementAttribute("allowanceCharge")]
        public DetallistaLineItemAllowanceCharge[] AllowanceCharge { get; set; }

        /// 
        [XmlElementAttribute("tradeItemTaxInformation")]
        public DetallistaLineItemTradeItemTaxInformation[] TradeItemTaxInformation { get; set; }

        /// 
        [XmlElement("totalLineAmount")]
        public DetallistaLineItemTotalLineAmount TotalLineAmount { get; set; }

        /// 
        [XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("SimpleInvoiceLineItemType")]
        public string Type { get; set; }

        /// 
        [XmlAttributeAttribute(DataType = "integer")]
        public string Number { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemTradeItemIdentification
    {
        /// 
        [XmlElement("gtin")]
        public string Gtin { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemAlternateTradeItemIdentification
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaLineItemAlternateTradeItemIdentificationType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemTradeItemDescriptionInformation
    {
        /// 
        [XmlElement("longText")]
        public string LongText { get; set; }

        /// 
        [XmlAttributeAttribute("language")]
        public DetallistaLineItemTradeItemDescriptionInformationLanguage Language { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool LanguageSpecified { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemInvoicedQuantity
    {
        /// 
        [XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string UnitOfMeasure { get; set; }

        /// 
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemAditionalQuantity
    {
        /// 
        [XmlAttributeAttribute("QuantityType")]
        public DetallistaLineItemAditionalQuantityQuantityType QuantityType { get; set; }

        /// 
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemGrossPrice
    {
        /// 
        [XmlElement("Amount")]
        public decimal Amount { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemNetPrice
    {
        /// 
        [XmlElement("Amount")]
        public decimal Amount { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemAdditionalInformation
    {
        /// 
        [XmlElement("referenceIdentification")]
        public DetallistaLineItemAdditionalInformationReferenceIdentification ReferenceIdentification { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemAdditionalInformationReferenceIdentification
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaLineItemAdditionalInformationReferenceIdentificationType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemCustoms
    {
        /// 
        [XmlElement("gln")]
        public string Gln { get; set; }

        /// 
        [XmlElement("alternatePartyIdentification")]
        public DetallistaLineItemCustomsAlternatePartyIdentification AlternatePartyIdentification { get; set; }

        /// 
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime ReferenceDate { get; set; }

        /// 
        [XmlElement("nameAndAddress")]
        public DetallistaLineItemCustomsNameAndAddress NameAndAddress { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemCustomsAlternatePartyIdentification
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaLineItemCustomsAlternatePartyIdentificationType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemCustomsNameAndAddress
    {
        /// 
        [XmlElement("name")]
        public string Name { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemLogisticUnits
    {
        /// 
        [XmlElement("serialShippingContainerCode")]
        public DetallistaLineItemLogisticUnitsSerialShippingContainerCode SerialShippingContainerCode { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemLogisticUnitsSerialShippingContainerCode
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaLineItemLogisticUnitsSerialShippingContainerCodeType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemPalletInformation
    {
        /// 
        [XmlElement("palletQuantity")]
        public string PalletQuantity { get; set; }

        /// 
        [XmlElement("description")]
        public DetallistaLineItemPalletInformationDescription Description { get; set; }

        /// 
        [XmlElement("transport")]
        public DetallistaLineItemPalletInformationTransport Transport { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemPalletInformationDescription
    {
        /// 
        [XmlAttributeAttribute("type")]
        public DetallistaLineItemPalletInformationDescriptionType Type { get; set; }

        /// 
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemPalletInformationTransport
    {
        /// 
        [XmlElement("methodOfPayment")]
        public DetallistaLineItemPalletInformationTransportMethodOfPayment MethodOfPayment { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemLotNumber
    {
        /// 
        [XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ProductionDate { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool ProductionDateSpecified { get; set; }

        /// 
        [XmlTextAttribute()]
        public string Value { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemAllowanceCharge
    {
        /// 
        [XmlElement("specialServicesType")]
        public DetallistaLineItemAllowanceChargeSpecialServicesType SpecialServicesType { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool SpecialServicesTypeSpecified { get; set; }

        /// 
        [XmlElement("monetaryAmountOrPercentage")]
        public DetallistaLineItemAllowanceChargeMonetaryAmountOrPercentage MonetaryAmountOrPercentage { get; set; }

        /// 
        [XmlAttributeAttribute("allowanceChargeType")]
        public DetallistaLineItemAllowanceChargeAllowanceChargeType AllowanceChargeType { get; set; }

        /// 
        [XmlAttributeAttribute("settlementType")]
        public DetallistaLineItemAllowanceChargeSettlementType SettlementType { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool SettlementTypeSpecified { get; set; }

        /// 
        [XmlAttributeAttribute("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemAllowanceChargeMonetaryAmountOrPercentage
    {
        /// 
        [XmlElement("percentagePerUnit")]
        public string PercentagePerUnit { get; set; }

        /// 
        [XmlElement("ratePerUnit")]
        public DetallistaLineItemAllowanceChargeMonetaryAmountOrPercentageRatePerUnit RatePerUnit { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemAllowanceChargeMonetaryAmountOrPercentageRatePerUnit
    {
        /// 
        [XmlElement("amountPerUnit")]
        public string AmountPerUnit { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemTradeItemTaxInformation
    {
        /// 
        [XmlElement("taxTypeDescription")]
        public DetallistaLineItemTradeItemTaxInformationTaxTypeDescription TaxTypeDescription { get; set; }

        /// 
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; set; }

        /// 
        [XmlElement("tradeItemTaxAmount")]
        public DetallistaLineItemTradeItemTaxInformationTradeItemTaxAmount TradeItemTaxAmount { get; set; }

        /// 
        [XmlElement("taxCategory")]
        public DetallistaLineItemTradeItemTaxInformationTaxCategory TaxCategory { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool TaxCategorySpecified { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemTradeItemTaxInformationTradeItemTaxAmount
    {
        /// 
        [XmlElement("taxPercentage")]
        public decimal TaxPercentage { get; set; }

        /// 
        [XmlElement("taxAmount")]
        public decimal TaxAmount { get; set; }
    }
    /// 



    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemTotalLineAmount
    {
        /// 
        [XmlElement("grossAmount")]
        public DetallistaLineItemTotalLineAmountGrossAmount GrossAmount { get; set; }

        /// 
        [XmlElement("netAmount")]
        public DetallistaLineItemTotalLineAmountNetAmount NetAmount { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemTotalLineAmountGrossAmount
    {
        /// 
        [XmlElement("Amount")]
        public decimal Amount { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaLineItemTotalLineAmountNetAmount
    {
        /// 
        [XmlElement("Amount")]
        public decimal Amount { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaTotalAmount
    {
        /// 
        [XmlElement("Amount")]
        public decimal Amount { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DetallistaTotalAllowanceCharge
    {
        /// 
        [XmlElement("specialServicesType")]
        public DetallistaTotalAllowanceChargeSpecialServicesType SpecialServicesType { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool SpecialServicesTypeSpecified { get; set; }

        /// 
        [XmlElement("Amount")]
        public decimal Amount { get; set; }

        /// 
        [XmlIgnoreAttribute()]
        public bool AmountSpecified { get; set; }

        /// 
        [XmlAttributeAttribute("allowanceOrChargeType")]
        public DetallistaTotalAllowanceChargeAllowanceOrChargeType AllowanceOrChargeType { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaRequestForPaymentIdentificationEntityType
    {
        /// 
        [XmlEnumAttribute("INVOICE")]
        Invoice,
        /// 
        [XmlEnumAttribute("DEBIT_NOTE")]
        DebitNote,
        /// 
        [XmlEnumAttribute("CREDIT_NOTE")]
        CreditNote,
        /// 
        [XmlEnumAttribute("LEASE_RECEIPT")]
        LeaseReceipt,
        /// 
        [XmlEnumAttribute("HONORARY_RECEIPT")]
        HonoraryReceipt,
        /// 
        [XmlEnumAttribute("_INVOICE")]
        InvoiceUnserscore,
        /// 
        [XmlEnumAttribute("TRANSPORT_DOCUMENT")]
        TransportDocument,
        /// 
        [XmlEnumAttribute("AUTO_INVOICE")]
        AutoInvoice,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaSpecialInstructionCode
    {
        /// 
        [XmlEnumAttribute("AAB")]
        Aab,
        /// 
        [XmlEnumAttribute("DUT")]
        Dut,
        /// 
        [XmlEnumAttribute("PUR")]
        Pur,
        /// 
        [XmlEnumAttribute("ZZZ")]
        Zzz,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaOrderIdentificationReferenceIdentificationType
    {
        /// 
        [XmlEnumAttribute("ON")]
        On,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaReferenceIdentificationType
    {
        /// 
        [XmlEnumAttribute("AAE")]
        Aae,
        /// 
        [XmlEnumAttribute("CK")]
        Ck,
        /// 
        [XmlEnumAttribute("ACE")]
        Ace,
        /// 
        [XmlEnumAttribute("ATZ")]
        Atz,
        /// 
        [XmlEnumAttribute("DQ")]
        Dq,
        /// 
        [XmlEnumAttribute("IV")]
        Iv,
        /// 
        [XmlEnumAttribute("ON")]
        On,
        /// 
        [XmlEnumAttribute("AWR")]
        Awr,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaSellerAlternatePartyIdentificationType
    {
        /// 
        [XmlEnumAttribute("SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY")]
        SellerAssignedIdentifierForAParty,
        /// 
        [XmlEnumAttribute("IEPS_REFERENCE")]
        IepsReference,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaInvoiceCreatorAlternatePartyIdentificationType
    {
        /// 
        [XmlEnumAttribute("VA")]
        Va,
        /// 
        [XmlEnumAttribute("IA")]
        Ia,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaCurrencyCurrencyFunction
    {
        /// 
        [XmlEnumAttribute("BILLING_CURRENCY")]
        BillingCurrency,
        /// 
        [XmlEnumAttribute("PRICE_CURRENCY")]
        PriceCurrency,
        /// 
        [XmlEnumAttribute("PAYMENT_CURRENCY")]
        PaymentCurrency,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaCurrencyCurrencyIsoCode
    {
        /// 
        [XmlEnumAttribute("MXN")]
        Mxn,
        /// 
        [XmlEnumAttribute("XEU")]
        Xeu,
        /// 
        [XmlEnumAttribute("USD")]
        Usd,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaPaymentTermsNetPaymentNetPaymentTermsType
    {
        /// 
        [XmlEnumAttribute("BASIC_NET")]
        BasicNet,
        /// 
        [XmlEnumAttribute("END_OF_MONTH")]
        EndOfMonth,
        /// 
        [XmlEnumAttribute("BASIC_DISCOUNT_OFFERED")]
        BasicDiscountOffered,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaPaymentTermsDiscountPaymentDiscountType
    {
        /// 
        [XmlEnumAttribute("ALLOWANCE_BY_PAYMENT_ON_TIME")]
        AllowanceByPaymentOnTime,
        /// 
        [XmlEnumAttribute("SANCTION")]
        Sanction,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaPaymentTermsPaymentTermsEvent
    {
        /// 
        [XmlEnumAttribute("DATE_OF_INVOICE")]
        DateOfInvoice,
        /// 
        [XmlEnumAttribute("EFFECTIVE_DATE")]
        EffectiveDate,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaPaymentTermsPaymentTermsRelationTime
    {
        /// 
        [XmlEnumAttribute("REFERENCE_AFTER")]
        ReferenceAfter,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaAllowanceChargeMonetaryAmountOrPercentageRateBase
    {
        /// 
        [XmlEnumAttribute("INVOICE_VALUE")]
        InvoiceValue,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaAllowanceChargeAllowanceChargeType
    {
        /// 
        [XmlEnumAttribute("ALLOWANCE_GLOBAL")]
        AllowanceGlobal,
        /// 
        [XmlEnumAttribute("CHARGE_GLOBAL")]
        ChargeGlobal,
    }

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaAllowanceChargeSettlementType
    {
        /// 
        [XmlEnumAttribute("BILL_BACK")]
        BillBack,
        /// 
        [XmlEnumAttribute("OFF_INVOICE")]
        OffInvoice,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemAlternateTradeItemIdentificationType
    {
        /// 
        [XmlEnumAttribute("BUYER_ASSIGNED")]
        BuyerAssigned,
        /// 
        [XmlEnumAttribute("SUPPLIER_ASSIGNED")]
        SupplierAssigned,
        /// 
        [XmlEnumAttribute("SERIAL_NUMBER")]
        SerialNumber,
        /// 
        [XmlEnumAttribute("GLOBAL_TRADE_ITEM_IDENTIFICATION")]
        GlobalTradeItemIdentification,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemTradeItemDescriptionInformationLanguage
    {
        /// 
        [XmlEnumAttribute("ES")]
        Es,
        /// 
        [XmlEnumAttribute("EN")]
        En,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemAditionalQuantityQuantityType
    {
        /// 
        [XmlEnumAttribute("NUM_CONSUMER_UNITS")]
        NumConsumerUnits,
        /// 
        [XmlEnumAttribute("FREE_GOODS")]
        FreeGoods,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemAdditionalInformationReferenceIdentificationType
    {
        /// 
        [XmlEnumAttribute("ON")]
        On,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemCustomsAlternatePartyIdentificationType
    {
        /// 
        [XmlEnumAttribute("TN")]
        Tn,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemLogisticUnitsSerialShippingContainerCodeType
    {
        /// 
        [XmlEnumAttribute("BJ")]
        Bj,
        /// 
        [XmlEnumAttribute("SRV")]
        Srv,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemPalletInformationDescriptionType
    {
        /// 
        [XmlEnumAttribute("EXCHANGE_PALLETS")]
        ExchangePallets,
        /// 
        [XmlEnumAttribute("RETURN_PALLETS")]
        ReturnPallets,
        /// 
        [XmlEnumAttribute("PALLET_80x100")]
        Pallet80X100,
        /// 
        [XmlEnumAttribute("CASE")]
        Case,
        /// 
        [XmlEnumAttribute("BOX")]
        Box,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemPalletInformationTransportMethodOfPayment
    {
        /// 
        [XmlEnumAttribute("PREPAID_BY_SELLER")]
        PrepaidBySeller,
        /// 
        [XmlEnumAttribute("PAID_BY_BUYER")]
        PaidByBuyer,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemAllowanceChargeAllowanceChargeType
    {
        /// 
        [XmlEnumAttribute("ALLOWANCE_GLOBAL")]
        AllowanceGlobal,
        /// 
        [XmlEnumAttribute("CHARGE_GLOBAL")]
        ChargeGlobal,
    }
    /// 
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemAllowanceChargeSettlementType
    {
        /// 
        [XmlEnumAttribute("OFF_INVOICE")]
        OffInvoice,
        /// 
        [XmlEnumAttribute("CHARGE_TO_BE_PAID_BY_VENDOR")]
        ChargeToBePaidByVendor,
        /// 
        [XmlEnumAttribute("CHARGE_TO_BE_PAID_BY_CUSTOMER")]
        ChargeToBePaidByCustomer,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemTradeItemTaxInformationTaxTypeDescription
    {
        /// 
        [XmlEnumAttribute("GST")]
        Gst,
        /// 
        [XmlEnumAttribute("VAT")]
        Vat,
        /// 
        [XmlEnumAttribute("LAC")]
        Lac,
        /// 
        [XmlEnumAttribute("AAA")]
        Aaa,
        /// 
        [XmlEnumAttribute("ADD")]
        Add,
        /// 
        [XmlEnumAttribute("FRE")]
        Fre,
        /// 
        [XmlEnumAttribute("LOC")]
        Loc,
        /// 
        [XmlEnumAttribute("STT")]
        Stt,
        /// 
        [XmlEnumAttribute("OTH")]
        Oth,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemTradeItemTaxInformationTaxCategory
    {
        /// 
        [XmlEnumAttribute("TRANSFERIDO")]
        Transferido,
        /// 
        [XmlEnumAttribute("RETENIDO")]
        Retenido,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaTotalAllowanceChargeAllowanceOrChargeType
    {
        /// 
        [XmlEnumAttribute("ALLOWANCE")]
        Allowance,
        /// 
        [XmlEnumAttribute("CHARGE")]
        Charge,
    }
    /// 
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaDocumentStatus
    {
        /// 
        [XmlEnumAttribute("ORIGINAL")]
        Original,
        /// 
        [XmlEnumAttribute("COPY")]
        Copy,
        /// 
        [XmlEnumAttribute("REEMPLAZA")]
        Reemplaza,
        /// 
        [XmlEnumAttribute("DELETE")]
        Delete,
    }

    /// 
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaTotalAllowanceChargeSpecialServicesType
    {
        /// 
        [XmlEnumAttribute("AA")]
        Aa,
        /// 
        [XmlEnumAttribute("ADS")]
        Ads,
        /// 
        [XmlEnumAttribute("ADO")]
        Ado,
        /// 
        [XmlEnumAttribute("ABZ")]
        Abz,
        /// 
        [XmlEnumAttribute("DA")]
        Da,
        /// 
        [XmlEnumAttribute("EAA")]
        Eaa,
        /// 
        [XmlEnumAttribute("PI")]
        Pi,
        /// 
        [XmlEnumAttribute("TAE")]
        Tae,
        /// 
        [XmlEnumAttribute("SAB")]
        Sab,
        /// 
        [XmlEnumAttribute("RAA")]
        Raa,
        /// 
        [XmlEnumAttribute("PAD")]
        Pad,
        /// 
        [XmlEnumAttribute("FG")]
        Fg,
        /// 
        [XmlEnumAttribute("FA")]
        Fa,
        /// 
        [XmlEnumAttribute("TD")]
        Td,
        /// 
        [XmlEnumAttribute("TS")]
        Ts,
        /// 
        [XmlEnumAttribute("TX")]
        Tx,
        /// 
        [XmlEnumAttribute("ZZZ")]
        Zzz,
        /// 
        [XmlEnumAttribute("VAB")]
        Vab,
        /// 
        [XmlEnumAttribute("UM")]
        Um,
        /// 
        [XmlEnumAttribute("DI")]
        Di,
        /// 
        [XmlEnumAttribute("ADT")]
        Adt,
        /// 
        [XmlEnumAttribute("AJ")]
        Aj,
        /// 
        [XmlEnumAttribute("CAC")]
        Cac,
        /// 
        [XmlEnumAttribute("COD")]
        Cod,
        /// 
        [XmlEnumAttribute("EAB")]
        Eab,
        /// 
        [XmlEnumAttribute("FC")]
        Fc,
        /// 
        [XmlEnumAttribute("FI")]
        Fi,
        /// 
        [XmlEnumAttribute("HD")]
        Hd,
        /// 
        [XmlEnumAttribute("QD")]
        Qd,
    }
    /// 
    /// 
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaPaymentTermsNetPaymentPaymentTimePeriodTimePeriodDueTimePeriod
    {
        /// 
        [XmlEnumAttribute("DAYS")]
        Days,
    }

    /// 
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaAllowanceChargeSpecialServicesType
    {
        /// 
        [XmlEnumAttribute("AA")]
        Aa,
        /// 
        [XmlEnumAttribute("AJ")]
        Aj,
        /// 
        [XmlEnumAttribute("ADO")]
        Ado,
        /// 
        [XmlEnumAttribute("ADT")]
        Adt,
        /// 
        [XmlEnumAttribute("ADS")]
        Ads,
        /// 
        [XmlEnumAttribute("ABZ")]
        Abz,
        /// 
        [XmlEnumAttribute("DA")]
        Da,
        /// 
        [XmlEnumAttribute("EAA")]
        Eaa,
        /// 
        [XmlEnumAttribute("EAB")]
        Eab,
        /// 
        [XmlEnumAttribute("PI")]
        Pi,
        /// 
        [XmlEnumAttribute("TAE")]
        Tae,
        /// 
        [XmlEnumAttribute("SAB")]
        Sab,
        /// 
        [XmlEnumAttribute("RAA")]
        Raa,
        /// 
        [XmlEnumAttribute("PAD")]
        Pad,
        /// 
        [XmlEnumAttribute("FG")]
        Fg,
        /// 
        [XmlEnumAttribute("FA")]
        Fa,
        /// 
        [XmlEnumAttribute("TD")]
        Td,
        /// 
        [XmlEnumAttribute("TS")]
        Ts,
        /// 
        [XmlEnumAttribute("TX")]
        Tx,
        /// 
        [XmlEnumAttribute("TZ")]
        Tz,
        /// 
        [XmlEnumAttribute("ZZZ")]
        Zzz,
        /// 
        [XmlEnumAttribute("VAB")]
        Vab,
        /// 
        [XmlEnumAttribute("UM")]
        Um,
        /// 
        [XmlEnumAttribute("DI")]
        Di,
        /// 
        [XmlEnumAttribute("CAC")]
        Cac,
        /// 
        [XmlEnumAttribute("COD")]
        Cod,
        /// 
        [XmlEnumAttribute("FC")]
        Fc,
        /// 
        [XmlEnumAttribute("FI")]
        Fi,
        /// 
        [XmlEnumAttribute("HD")]
        Hd,
        /// 
        [XmlEnumAttribute("QD")]
        Qd,
    }

    /// 
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public enum DetallistaLineItemAllowanceChargeSpecialServicesType
    {
        /// 
        [XmlEnumAttribute("AA")]
        Aa,
        /// 
        [XmlEnumAttribute("ADS")]
        Ads,
        /// 
        [XmlEnumAttribute("ADO")]
        Ado,
        /// 
        [XmlEnumAttribute("ABZ")]
        Abz,
        /// 
        [XmlEnumAttribute("DA")]
        Da,
        /// 
        [XmlEnumAttribute("EAA")]
        Eaa,
        /// 
        [XmlEnumAttribute("PI")]
        Pi,
        /// 
        [XmlEnumAttribute("TAE")]
        Tae,
        /// 
        [XmlEnumAttribute("SAB")]
        Sab,
        /// 
        [XmlEnumAttribute("RAA")]
        Raa,
        /// 
        [XmlEnumAttribute("PAD")]
        Pad,
        /// 
        [XmlEnumAttribute("FG")]
        Fg,
        /// 
        [XmlEnumAttribute("FA")]
        Fa,
        /// 
        [XmlEnumAttribute("TD")]
        Td,
        /// 
        [XmlEnumAttribute("TS")]
        Ts,
        /// 
        [XmlEnumAttribute("TX")]
        Tx,
        /// 
        [XmlEnumAttribute("ZZZ")]
        Zzz,
        /// 
        [XmlEnumAttribute("VAB")]
        Vab,
        /// 
        [XmlEnumAttribute("UM")]
        Um,
        /// 
        [XmlEnumAttribute("DI")]
        Di,
        /// 
        [XmlEnumAttribute("ADT")]
        Adt,
        /// 
        [XmlEnumAttribute("AJ")]
        Aj,
        /// 
        [XmlEnumAttribute("CAC")]
        Cac,
        /// 
        [XmlEnumAttribute("COD")]
        Cod,
        /// 
        [XmlEnumAttribute("EAB")]
        Eab,
        /// 
        [XmlEnumAttribute("FC")]
        Fc,
        /// 
        [XmlEnumAttribute("FI")]
        Fi,
        /// 
        [XmlEnumAttribute("HD")]
        Hd,
        /// 
        [XmlEnumAttribute("QD")]
        Qd,
    }


}