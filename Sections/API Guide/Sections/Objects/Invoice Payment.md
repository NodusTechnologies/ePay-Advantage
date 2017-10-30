## Invoice Payment
Invoice payment object represents the application of a payment to an invoice. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Payment](#payment)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| DocumentSource | String | Source of the document | nvarchar(25) |
| Identity | Decimal | Invoice number identifier (Optional if using Invoice number) | decimal(19,2) |
| InvoiceNumber\* | String | Invoice number | nvarchar(30) |
| OriginatingAmount | Decimal | Payment amount applied to the invoice in the payment currency | decimal(19,2) |
| PaymentAmount | Decimal | Payment amount applied to the invoice in the functional currency | decimal(19,2) |
| PaymentNumber\* | String | Payment number | decimal(19,5) |
\*Required
