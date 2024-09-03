using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

/*


namespace ApiConsoleApp
{
    [XmlRoot("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    //Crear Clases para Representar la Estructura del XML
    public class Factura
    {

        [XmlElement("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueDate { get; set; }

        [XmlElement("DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CurrencyCode { get; set; }

        [XmlElement("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierParty SupplierParty { get; set; }

        [XmlElement("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerParty CustomerParty { get; set; }

        [XmlElement("LegalMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotal MonetaryTotal { get; set; }

        [XmlElement("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<InvoiceLine> InvoiceLines { get; set; }
    }

    public class SupplierParty
    {
        [XmlElement("Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party Party { get; set; }
    }

    public class CustomerParty
    {
        [XmlElement("Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party Party { get; set; }
    }

    public class Party
    {
        [XmlElement("PartyIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyIdentification PartyIdentification { get; set; }

        [XmlElement("PartyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyName PartyName { get; set; }
    }

    public class PartyIdentification
    {
        [XmlElement("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }
    }

    public class PartyName
    {
        [XmlElement("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name { get; set; }
    }

    public class MonetaryTotal
    {
        [XmlElement("PayableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string PayableAmount { get; set; }
    }

    public class InvoiceLine
    {
        [XmlElement("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement("InvoicedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Quantity { get; set; }

        [XmlElement("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string LineExtensionAmount { get; set; }

        [XmlElement("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Item Item { get; set; }
    }

    public class Item
    {
        [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Description { get; set; }

        [XmlElement("SellersItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SellersItemIdentification SellersItemIdentification { get; set; }
    }

    public class SellersItemIdentification
    {
        [XmlElement("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }
    }



}

*/