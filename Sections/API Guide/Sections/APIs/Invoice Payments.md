Invoice Payments
============

The Invoice Payment API is used for creating, updating and viewing the application of payments to invoices on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Invoice Payment
--------------------

* `POST /invoiceLineItem` will create or update a payment for a specific invoice on the EPay Advantage website based on the request JSON payload. If updating an invoice payment, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
  "DocumentSource": "SOP",
  "Identity": null,
  "InvoiceNumber": "STDINV999999",
  "OriginatingAmount": "30.00",
  "PaymentAmount": "1.00",
  "PaymentNumber": "APIPMT000000001"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Invoice%20Payment.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>


Retrieve Invoice Payments
--------------------

* `GET /invoicePayment?paymentNumber={PAYMENTNUMBER}` will get the invoice payment that is applied to an inovice for a specific payment on the EPay Advantage website based on the URL parameter.

###### Request
<pre>
  POST /invoiceLineItem?paymentNumber=APIPMT000000001
</pre>

###### Response
<pre>
{
  "Message": null,
  "Result": [{
    "Amount": 128.3,
    "Discount": "0",
    "Identity": "",
    "InvoiceID": "STDINV999999",
    "PaymentType": "9",
    "RMType": "1"
  }]
}
</pre>

