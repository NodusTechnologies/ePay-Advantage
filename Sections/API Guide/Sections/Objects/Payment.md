## Payment
Payment object represents a payment in the EPay Advantage site.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total payment amount in the functional currency  | decimal(19,2) |
| BalanceAmount | Decimal | Total balance amount in the functional currency | decimal(19,2) |
| BatchNumber | String | Batch number | nvarchar(25) |
| CashReceiptType | String | Type of cash receipt | nvarchar(25) |
| CheckNumber | String | Check number used | nvarchar(4000) |
| CreatedOn\* | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| CurrencyID\* | String | Currency code | nvarchar(25) |
| CustomerNumber\* | String | Customer ID specified by the client | nvarchar(25) |
| InvoicePayments | [Object](#invoice-payment) | Invoice payment object |
| IsVoid | Boolean | Indicates if the payment is voided | bit |
| OriginatingAmount | Decimal | Total payment amount in the payment currency | decimal(19,2) |
| OriginatingBalanceAmount | Deciaml | Total balance amount in the payment currency  | decimal(19,2) |
| PaymentNumber\* | String | Payment number | nvarchar(25) |
| PaymentType | Int | Payment type (7 = Credit Memo, 8 = Return, 9 = Payment) | int |
\*Required
