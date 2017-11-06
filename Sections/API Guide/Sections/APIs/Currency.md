Currency
============

The Currency API is used for creating, updating, and deleting available currencies. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create a Currency
--------------------

* `POST /currency` will create and save a currency to the EPay Advantage website based on the JSON request payload

###### Request
<pre>
{
  <b>"CurrencyID": "USD"</b>,
  "CurrencyIndex": "1234",
  "Description": "USD Currency",
  "IsFuncCurrency": 0,
  "Symbol": "$"
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

Delete a Currency
--------------------

* `DELETE /currency?currencyid={CurrencyID}` will delete a currency on the EPay Advantage website based on the URL parameter

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
