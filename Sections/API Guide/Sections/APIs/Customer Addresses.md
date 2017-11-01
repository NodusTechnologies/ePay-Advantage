Customer Addresses
============

The Customer Address API is used for creating, and updating customer addresses on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update a Customer Address
--------------------

* `POST /customeraddress` will create and save an address for a customer to the EPay Advantage website based on the JSON request payload. If updating an address, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
  "Address1": "1234 Street",
  "Address2": null,
  "Address3": null,
  <b>"AddressID": "SECONDARY"</b>,
  "City": "Los Angeles",
  "Country": "US",
  <b>"CustomerNumber": "TEST"</b>,
  "EMailAddress": "TEST@nodus.com",
  "Fax": null,
  "Name": "TEST USER",
  "Phone1": "1234567890",
  "Phone2": null,
  "Phone3": null,
  "SalesPersonID": null,
  "ShippingMethod": null,
  "SiteID": null,
  "State": "CA",
  "TaxScheduleID": null,
  "TerritoryID": null,
  "UPSZone": null,
  "UserDefine1": null,
  "UserDefine2": null,
  "Zip": "12345"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Address.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
