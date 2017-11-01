Returns
============

The Return API is used for creating, and updating return header information on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update a Return
--------------------

* `POST /return` will create or update a return on the EPay Advantage website based on the JSON request payload. If updating a return, make sure to send all values again, otherwise, they will be overwritten.

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
  "DocTypeID": "RTNINV",
  "DocumentSource": "SOP",
  <b>"DueOn": "10/30/2017 3:19:11 PM"</b>,
  "Freight": "0.00",
  <b>"InvoiceNumber": "RTNINV999999"</b>,
  "InvoiceType": "8",
  "Misc": "0.00",
  "ORIGNUMB": "RTNINV999999",
  "ORIGTYPE": "8",
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
    "InvoiceNumber": "RTNINV999999",
    "InvoiceType": "8",
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

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Return.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
