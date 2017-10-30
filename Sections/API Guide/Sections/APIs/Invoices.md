Invoices
============

The Invoice API is used for creating, updating and viewing invoices on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Invoice
--------------------

* `POST /invoice` will create or update an invoice on the EPay Advantage website based on the request JSON payload. If updating an invoice, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
  "Amount": "30.00",
  "BalanceDue": "30.00",
  "BatchNumber": null,
  "BillingAddressName": "PRIMARY",
  "Comments": null,
  <b>"CreatedOn": "10/30/2017 3:19:11 PM"</b>,
  "CurrencyID": "Z-US$",
  <b>"CustomerNumber": "TEST"</b>,
  "Discount": "0.00",
  "DocTypeID": "STDINV",
  "DocumentSource": "SOP",
  <b>"DueOn": "10/30/2017 3:19:11 PM"</b>,
  "Freight": "0.00",
  <b>"InvoiceNumber": "STDINV999999"</b>,
  "InvoiceType": "3",
  "Misc": "0.00",
  "ORIGNUMB": "STDINV999999",
  "ORIGTYPE": "3",
  "OriginatingAmount": "30.00",
  "OriginatingBalanceDue": "30.00",
  "OriginatingDiscount": "0.00",
  "OriginatingFreight": "0.00",
  "OriginatingMisc": "0.00",
  "OriginatingSubtotal": "30.00",
  "OriginatingTax": "0.00",
  "PONumber": null,
  "PaymentTerms": null,
  "SalesPersonID": "SANDRA M.",
  "ShipToAddress": {
    "Address1": "1234 Street",
    "Address2": null,
    "Address3": null,
    "AddressID": "PRIMARY",
    "City": "Los Angeles",
    "Country": "US",
    "EMailAddress": "TEST@nodus.com",
    "Fax": null,
    "Name": "Test User",
    "Phone1": "1234567890",
    "Phone2": null,
    "Phone3": null,
    "SalesPersonID": "SANDRA M.",
    "ShippingMethod": "GROUND",
    "SiteID": "WAREHOUSE",
    "State": "CA",
    "TaxScheduleID": null,
    "TerritoryID": null,
    "UPSZone": null,
    "UserDefine1": null,
    "UserDefine2": null,
    "Zip": "12345"
  },
  "ShippingMethod": "GROUND",
  "SiteID": "WAREHOUSE",
  "Subtotal": "30.00",
  "Tax": "0.00",
  "TermDiscounts": null,
  "Tracking_Number": null,
  "invoiceEntries": [{
    "Description": "TEST Item",
    "ExtendedPrice": "30.00",
    "InvoiceNumber": "STDINV999999",
    "InvoiceType": "3",
    "ItemCode": "TEST",
    "Markdown": "0.00",
    "MarkdownPercentage": "0.00",
    "NonInventory": "1",
    "OriginatingExtendedPrice": "30.00",
    "OriginatingMarkdown": "0.00",
    "OriginatingTaxAmount": "0.00",
    "OriginatingUnitPrice": "30.00",
    "PriceLevel": "RETAIL",
    "Quantity": "1",
    "ReqShipDate": "10/30/2017 3:19:11 PM",
    "SalesPersonID": "SANDRA M.",
    "Sequence": "1",
    "ShipToAddress": {
      "Address1": "1234 Street",
      "Address2": null,
      "Address3": null,
      "AddressID": "PRIMARY",
      "City": "Los Angeles",
      "Country": "US",
      "EMailAddress": "TEST@nodus.com",
      "Fax": null,
      "Name": "Test User",
      "Phone1": "1234567890",
      "Phone2": null,
      "Phone3": null,
      "SalesPersonID": "SANDRA M.",
      "ShippingMethod": "GROUND",
      "SiteID": "WAREHOUSE",
      "State": "CA",
      "TaxScheduleID": null,
      "TerritoryID": null,
      "UPSZone": null,
      "UserDefine1": null,
      "UserDefine2": null,
      "Zip": "12345"
    },
    "ShippingMethod": "GROUND",
    "SiteID": "WAREHOUSE",
    "TaxAmount": "0.00",
    "Taxable": "0",
    "UnitOfMeasure": "EACH",
    "UnitPrice": "30.00"
  }]
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Currency.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>


Retrieve Invoices
--------------------

* `GET /invoice?customerNumber={CustomerNumber}` will get the invoices for a specific customer on the EPay Advantage website based on the URL parameters.

Options
-------

This request accepts the below query string parameters to add options. You can use below query parameters by adding them to your request URL by connecting additional ones with a '&'.

| QueryString | Description | 
| :------------- | :------------- | 
| posted | Search for a posted or unposted invoice. Values are defined as `false` for unposted or `true` for posted. Default value is `true` |
| startDate | Search by invoice start date |

###### Request
<pre>
  POST /invoice?customerNumber=TEST
</pre>

###### Response
<pre>
{
  "Message": null,
  "Result": [{
      "Amount": 4987.23,
      "BalanceDue": 0,
      "BatchNumber": "BEG BAL",
      "BillingAddressName": "BILLING",
      "Comments": "",
      "CreatedOn": "2013-11-13",
      "CurrencyID": "Z-US$",
      "CustomerNumber": "TEST",
      "Discount": 0,
      "DocTypeID": "SERVICE & REPAIR",
      "DocumentSource": "RM",
      "DueOn": "2013-12-13",
      "Freight": 0,
      "Identity": "",
      "InvoiceNumber": "SVC1006",
      "InvoiceType": 5,
      "Misc": 0,
      "ORIGNUMB": " ",
      "ORIGTYPE": 0,
      "OriginatingAmount": 4987.23,
      "OriginatingBalanceDue": 0,
      "OriginatingDiscount": 0,
      "OriginatingFreight": 0,
      "OriginatingMisc": 0,
      "OriginatingSubtotal": 4987.23,
      "OriginatingTax": 0,
      "PONumber": "",
      "PaymentTerms": "Net 30",
      "SalesPersonID": "SANDRA M.",
      "ShipToAddress": null,
      "ShippingMethod": "GROUND",
      "SiteID": null,
      "Subtotal": 4987.23,
      "Tax": 0,
      "TermDiscounts": [{
        "DiscardDate": "1970-01-01",
        "DiscountAvailableAmount": 0
      }],
      "Tracking_Number": " ",
      "invoiceEntries": null
    },
    {
      "Amount": 10.7,
      "BalanceDue": 10.7,
      "BatchNumber": "sa",
      "BillingAddressName": "BILLING",
      "Comments": "",
      "CreatedOn": "2017-04-12",
      "CurrencyID": "Z-US$",
      "CustomerNumber": "TEST",
      "Discount": 0,
      "DocTypeID": "STDINV",
      "DocumentSource": "SOP",
      "DueOn": "2017-05-12",
      "Freight": 0,
      "Identity": "",
      "InvoiceNumber": "STDINV2267",
      "InvoiceType": 3,
      "Misc": 0,
      "ORIGNUMB": " ",
      "ORIGTYPE": 0,
      "OriginatingAmount": 10.7,
      "OriginatingBalanceDue": 10.7,
      "OriginatingDiscount": 0,
      "OriginatingFreight": 0,
      "OriginatingMisc": 0,
      "OriginatingSubtotal": 10,
      "OriginatingTax": 0.7,
      "PONumber": "",
      "PaymentTerms": "Net 30",
      "SalesPersonID": "SANDRA M.",
      "ShipToAddress": {
        "Address1": "23456 Meridan St. N.E.",
        "Address2": "",
        "Address3": "",
        "AddressID": "PRIMARY",
        "City": "Green Bay",
        "Country": "USA",
        "EMailAddress": "",
        "Fax": "41455501250000",
        "Name": "Jia Zhou",
        "Phone1": "41455501250000",
        "Phone2": "00000000000000",
        "Phone3": "",
        "SalesPersonID": null,
        "ShippingMethod": null,
        "SiteID": null,
        "State": "WI",
        "TaxScheduleID": null,
        "TerritoryID": null,
        "UPSZone": "",
        "UserDefine1": "",
        "UserDefine2": "",
        "Zip": "54305-5303"
      },
      "ShippingMethod": "GROUND",
      "SiteID": "WAREHOUSE",
      "Subtotal": 10,
      "Tax": 0.7,
      "TermDiscounts": [{
        "DiscardDate": "2017-04-12",
        "DiscountAvailableAmount": 0
      }],
      "Tracking_Number": " ",
      "invoiceEntries": null
    }
  ]
}
</pre>
