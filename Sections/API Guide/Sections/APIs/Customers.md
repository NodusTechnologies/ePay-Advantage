Customer
============

The Customer API is used for creating, updating, and viewing customers on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update a Customer
--------------------

* `POST /customer` will create or update a customer to the EPay Advantage website based on the request JSON payload. If updating a customer, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
  "BillingAddress": {
    "Address1": "1234 Street",
    "Address2": null,
    "Address3": null,
    <b>"AddressID": "PRIMARY"</b>,
    "City": "Los Angeles",
    "Country": "US",
    <b>"CustomerNumber":"TEST"</b>,
    "EMailAddress": "TEST@nodus.com",
    "Fax": null,
    "Name": "Test User",
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
  },
  "ClassID": null,
  "Comment1": null,
  "Comment2": null,
  "CreditLimitAmount": "0.00",
  "CreditLimitType": "0",
  "CurrencyID": null,
  <b>"CustomerNumber": "TEST"</b>,
  "Email": "TEST@nodus.com",
  "Inactive": "0",
  "Name": "Test User",
  "OnHold": "0",
  "ParentCustomerNumber": "TEST",
  "PaymentTerms": null,
  "PriceLevel": null,
  "PrimaryAddress": {
    "Address1": "1234 Street",
    "Address2": null,
    "Address3": null,
    <b>"AddressID": "PRIMARY"</b>,
    "City": "Los Angeles",
    "Country": "US",
    <b>"CustomerNumber":"TEST"</b>,
    "EMailAddress": "TEST@nodus.com",
    "Fax": null,
    "Name": "Test User",
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
  },
  "SalesPersonID": null,
  "SalesTerritoryID": null,
  "ShippingAddress": {
    "Address1": "1234 Street",
    "Address2": null,
    "Address3": null,
    <b>"AddressID": "PRIMARY"</b>,
    "City": "Los Angeles",
    "Country": "US",
    <b>"CustomerNumber":"TEST"</b>,
    "EMailAddress": "TEST@nodus.com",
    "Fax": null,
    "Name": "Test User",
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
  },
  "ShippingMethod": "GROUND",
  "StatementName": "Nodus",
  "TaxExempt": "0",
  "TaxScheduleID": null,
  "TradeDiscount": "0.00",
  "UserDefine1": null,
  "UserDefine2": null
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Customer.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>


Retrieve Customers
--------------------

* `GET /customer` will retrieve all customers from EPay Advantage website

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | 
| :------------- | :------------- | 
| customerNumber | Search by customer number |
| name | Search by customer name |

###### Request
<pre>
  GET /customer?customerNumber=COMPUTEC0001
</pre>

###### Response
<pre>
[
  {
    "BillingAddress": {
      "Address1": "P.O. Box 2734",
      "Address2": "",
      "Address3": "",
      "AddressID": "BILLING",
      "City": "Green Bay",
      "Country": "USA",
      "EMailAddress": "",
      "Fax": "41455501450000",
      "Name": "Jia Zhou",
      "Phone1": "41455501450000",
      "Phone2": "00000000000000",
      "Phone3": "",
      "SalesPersonID": null,
      "ShippingMethod": "MAIL",
      "SiteID": null,
      "State": "WI",
      "TaxScheduleID": "USASTCITY-6*",
      "TerritoryID": null,
      "UPSZone": "",
      "UserDefine1": "",
      "UserDefine2": "",
      "Zip": "54305-5303"
    },
    "ClassID": "USA-MNWI-T4",
    "Comment1": "",
    "Comment2": "",
    "CreditLimitAmount": 40000,
    "CreditLimitType": 2,
    "CustomerNumber": "COMPUTEC0001",
    "Deleted": 0,
    "Email": "Michael.Daigh@nodus.com",
    "Inactive": false,
    "LoginID": "COMPUTEC0001",
    "Name": "Compu-Tech Solutions",
    "OnHold": false,
    "ParentCustomerNumber": "COMPUTEC0001",
    "Password": null,
    "PaymentTerms": "Net 30",
    "PriceLevel": "",
    "PrimaryAddress": {
      "Address1": "1 voie Felix Evoue, Pte 213",
      "Address2": "",
      "Address3": "",
      "AddressID": "PRIMARY",
      "City": "Creteil",
      "Country": "FRANCE",
      "EMailAddress": "",
      "Fax": "41455501250000",
      "Name": "Jia Zhou",
      "Phone1": "41455501250000",
      "Phone2": "00000000000000",
      "Phone3": "",
      "SalesPersonID": "SANDRA M.",
      "ShippingMethod": "GROUND",
      "SiteID": null,
      "State": "WI",
      "TaxScheduleID": "USASTCITY-6*",
      "TerritoryID": null,
      "UPSZone": "",
      "UserDefine1": "",
      "UserDefine2": "",
      "Zip": "9400"
    },
    "SalesPersonID": "SANDRA M.",
    "SalesTerritoryID": "TERRITORY 4",
    "ShippingAddress": {
      "Address1": "1 voie Felix Evoue, Pte 213",
      "Address2": "",
      "Address3": "",
      "AddressID": "PRIMARY",
      "City": "Creteil",
      "Country": "FRANCE",
      "EMailAddress": "",
      "Fax": "41455501250000",
      "Name": "Jia Zhou",
      "Phone1": "41455501250000",
      "Phone2": "00000000000000",
      "Phone3": "",
      "SalesPersonID": "SANDRA M.",
      "ShippingMethod": "GROUND",
      "SiteID": null,
      "State": "WI",
      "TaxScheduleID": "USASTCITY-6*",
      "TerritoryID": null,
      "UPSZone": "",
      "UserDefine1": "",
      "UserDefine2": "",
      "Zip": "9400"
    },
    "ShippingMethod": "GROUND",
    "StatementName": "Compu-Tech Solutions",
    "TaxExempt": false,
    "TaxScheduleID": "USASTCITY-6*",
    "TradeDiscount": 0,
    "UserDefine1": "Wholesale",
    "UserDefine2": ""
  }
]
</pre>
