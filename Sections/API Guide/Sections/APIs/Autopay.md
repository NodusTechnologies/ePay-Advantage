Autopay
============

The Autopay API is used for creating, and updating autopay contracts on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Autopay Contract
--------------------

* `POST /autopay` will create and save an autopay contract for a customer to the EPay Advantage website based on the JSON request payload. If updating an autopay contract, you can send only the required fields and the fields that need to be changed.

###### Request
<pre>
 {
	"AccountType":"All",
	"Accounts":"",
	"Amount":1.23,
	"ContractDescription":"Description",
	"CreatedOn":"2018-09-18",
	"Currency":"Z-US$",
	<b>"CustomerNumber":"COMPUTEC0001"</b>,
	"EndDate":"",
	"EndType":"None",
	<b>"Frequency":"Daily"</b>,
	"MaxOccurrences":null,
	<b><i>"NextPaymentDate":"2018-09-18"</i></b>,
	<b>"PaymentMethod":"CC"</b>,
	<b><i>"PaymentOption":"FixedAmount"</i></b>,
	"ProcessOnDay":18,
	"StartDate":"2018-09-18",
	"Status":"Active"
}
</pre>

Please note that **bold** fields are required fields, **bold** and **italicized** are required for new contracts, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Autopay.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
