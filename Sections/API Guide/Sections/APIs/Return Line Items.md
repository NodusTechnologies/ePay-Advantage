Return Line Items
============

The Return Line Item API is used for creating, updating and viewing return line items on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Return Line Item
--------------------

* `POST /returnLineItem` will create or update a line item for a specific return on the EPay Advantage website based on the request JSON payload and URL parameters, both of which are required. If updating an item, make sure to send all values again, otherwise, they will be overwritten.

Options
-------

This request accepts the below query string parameters to add options. You can use below query parameters by adding them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | 
| :------------- | :------------- | 
| invoiceNumber | Search by return number |
| identity | Search by invoice identity |

###### Request
<pre>
  POST /returnLineItem?invoiceNumber=RTNINV999999
</pre>

<pre>
[
  {
    "Description": "TEST Item",
    "ExtendedPrice": "0.00",
    "InvoiceNumber": "RTNINV999999",
    "InvoiceType": "8",
    "ItemCode": "TEST",
    "Markdown": "0.00",
    "MarkdownPercentage": "0.00",
    "NonInventory": "1",
    "OriginatingExtendedPrice": "0.00",
    "OriginatingMarkdown": "0.00",
    "OriginatingTaxAmount": "0.00",
    "OriginatingUnitPrice": "0.00",
    "PriceLevel": "RETAIL",
    "Quantity": "1",
    <b>"ReqShipDate": "10/30/2017 2:45:20 PM"</b>,
    "SalesPersonID": "SANDRA M.",
    "Sequence": "2",
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
    "UnitPrice": "0.00"
  }
]
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Return%20Line%20Item.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
