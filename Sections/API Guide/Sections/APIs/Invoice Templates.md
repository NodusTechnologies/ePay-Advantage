Invoice Templates
============

The Invoice Template API is used for creating, updating and deleting invoice header information on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Invoice Template
--------------------

* `POST /invoicetemplate` will create or update an invoice template on the EPay Advantage website based on the request JSON payload. If updating an invoice template, make sure to send all values again, otherwise, they will be overwritten.

Options for GroupVars
-------

This request accepts the below values in the GroupVars variable. This will split the invoice template dependent on the values given. For example, if you have two separate line items using two different shipping methods, it will split the invoice to display them separately. You can use below query parameters by adding them to variable by connecting additional ones with a ','.

| QueryString | Description | 
| :------------- | :------------- | 
| ShippingName | Shipping name |
| ReqShipDate | Required ship date |
| a.Name | Customer name on the address  |
| a.Address1 | Address line 1 field |
| a.Address2 | Address line 2 field |
| a.Address3 | Address line 3 field |
| a.City | City name |
| a.State | State name |
| a.Zip | Zip code |
| a.Country | Country name |

###### Request
```
<pre>
{
  "GroupVars": "ShippingName, a.name",
  "LineItems": "<div><span>Line Items</span></div>",
  "Locked": "false",
  "MainBody": "<div><span>Main Body</span><div>[[[LineItemSection]]]</div><div>[[[AppliedPaymentsSection]]]</div></div>",
  <b>"Name": "TEST"</b>,
  "Payments": "<div><span>Payments</span></div>"
}
</pre>
```

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Invioce%20Template.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>


Delete InvoiceTemplate
--------------------

* `DELETE /invoicetemplate?name={InvoiceTemplateName}` will delete the invoice template with that name on the EPay Advantage website based on the URL parameters.

###### Request
<pre>
  POST /invoicetemplate?name=TEST
</pre>

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
