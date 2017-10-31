Payments
============

The Payment API is used for creating, updating and viewing payment information on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update a Payment
--------------------

* `POST /payment` will create or update a payment on the EPay Advantage website based on the request JSON payload. If updating a payment, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
  "Amount": "1.00",
  "BalanceAmount": "1.00",
  "BatchNumber": "API20171031",
  "CashReceiptType": "Credit Card/ECheck",
  "CheckNumber": null,
  <b>"CreatedOn": "10/31/2017 2:33:20 PM"</b>,
  <b>"CurrencyID": "Z-US$"</b>,
  <b>"CustomerNumber": "TEST"</b>,
  "InvoicePayments": [{
    "DocumentSource": "SOP",
    "Identity": null,
    "InvoiceNumber": "STDINV999999",
    "OriginatingAmount": "1.00",
    "PaymentAmount": "1.00",
    "PaymentNumber": "APIPMT000000001"
  }],
  "IsVoid": "0",
  "OriginatingAmount": "1.00",
  "OriginatingBalanceAmount": "1.00",
  <b>"PaymentNumber": "APIPMT000000001"</b>,
  "PaymentType": "9"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Payment.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>


Retrieve Payments
--------------------

* `GET /payment` will get the invoices' header information for a specific customer on the EPay Advantage website based on the URL parameters.

Options
-------

This request accepts the below query string parameters to add options. You can use below query parameters by adding them to your request URL by connecting additional ones with a '&'.

| QueryString | Description | 
| :------------- | :------------- | 
| status | Payment status (`0`: scheduled; `1`: processed; `2`: failed; `3`: voided)  |
| customerNumber | Customer number |
| paymentNumber | Payment number |
| type | Payment type (`7`: Credit Memo, `8`: Return, `9`: Payment) |
| startDate | Search by document date beginning at the specified interval |
| endDate | Search by document date ending at the specified interval |
| masterType | Customer number |
| currency | Payment currency code |
| pageSize | Maximum number of payments returned |

###### Request
<pre>
  POST /payment?customerNumber=TEST&pageSize=1
</pre>

###### Response
<pre>
{
  "Message": null,
  "Result": [{
    "Amount": 1.00,
    "AppliedAmount": 1.00,
    "BalanceAmount": 0,
    "BatchNumber": "RM4",
    "Canceled": 0,
    "CashReceiptType": "Check",
    "CheckNumber": "66665",
    "Comment": null,
    "Comment2": null,
    "CreatedOn": "2014-01-31 00:00:00",
    "CurrencyCode": "Z-US$",
    "CustomerNumber": "TEST",
    "DateDue": "1900-01-01 00:00:00",
    "FailedAttempts": 0,
    "Identity": "",
    "InvoicePayment": [{
      "DocumentSource": "SOP",
      "Identity": null,
      "InvoiceNumber": "STDINV999999",
      "OriginatingAmount": "1.00",
      "PaymentAmount": "1.00",
      "PaymentNumber": "APIPMT000000002"
    }],
    "LastAttempt": "2014-01-31 00:00:00",
    "LastMessage": "",
    "MasterType": "Back Office",
    "Name": "Test User",
    "OriginatingAmount": 1.00,
    "OriginatingAppliedAmount": 1.00,
    "OriginatingBalanceAmount": 0,
    "PaymentID": "af42218d-ed56-448e-ba7b-018e66b44b27",
    "PaymentNumber": "APIPMT000000002",
    "PaymentStatus": 1,
    "PaymentType": 9,
    "Transaction": null,
    "WalletEntryID": null
  }]
}
</pre>
