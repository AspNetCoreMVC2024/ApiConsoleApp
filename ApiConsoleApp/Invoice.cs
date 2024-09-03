using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ApiConsoleApp
{
    [XmlRoot("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    public class Invoice
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement(ElementName = "IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateTime IssueDate { get; set; }

        [XmlElement(ElementName = "DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string DocumentCurrencyCode { get; set; }

        [XmlElement(ElementName = "AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingSupplierParty SupplierParty { get; set; }

        [XmlElement(ElementName = "AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingCustomerParty CustomerParty { get; set; }

        [XmlElement(ElementName = "LegalMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotal MonetaryTotal { get; set; }

        [XmlElement(ElementName = "InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<InvoiceLine> InvoiceLines { get; set; }



    }

    public class AccountingSupplierParty
    {
        [XmlElement(ElementName = "Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party Party { get; set; }
    }

    public class AccountingCustomerParty
    {
        [XmlElement(ElementName = "Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party Party { get; set; }
    }

    public class Party
    {
        [XmlElement(ElementName = "PartyIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyIdentification PartyIdentification { get; set; }

        [XmlElement(ElementName = "PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyLegalEntity PartyLegalEntity { get; set; }
    }

    public class PartyIdentification
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }
    }

    public class PartyLegalEntity
    {
        [XmlElement(ElementName = "RegistrationName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string RegistrationName { get; set; }
    }

    public class MonetaryTotal
    {
        [XmlElement(ElementName = "PayableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal PayableAmount { get; set; }
    }

    public class InvoiceLine
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement(ElementName = "InvoicedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal Quantity { get; set; }

        [XmlElement(ElementName = "LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal LineExtensionAmount { get; set; }

        [XmlElement(ElementName = "Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Item Item { get; set; }
    }

    public class Item
    {
        [XmlElement(ElementName = "Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Description { get; set; }

        [XmlElement(ElementName = "SellersItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SellersItemIdentification SellersItemIdentification { get; set; }
    }

    public class SellersItemIdentification
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }
    }




}
