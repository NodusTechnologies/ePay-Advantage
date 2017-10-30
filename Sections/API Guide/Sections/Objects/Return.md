## Return
Return object represnets a return that can be seen in the EPay Advantage site.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total invoice amount in the functional currency  | decimal(19,2) |
| BalanceDue | Decimal | Total balance due in the functional currency | decimal(19,2) |
| BatchNumber | String | Batch number | nvarchar(25) |
| BillingAddressName | String | Billing address identifier | nvarchar(25) |
| Comments | String | Additional comments | nvarchar(4000) |
| CreatedOn\* | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| CurrencyID | String | Currency code | nvarchar(25) |
| CustomerNumber\* | String | Customer ID specified by the client | nvarchar(25) |
| Discount | Decimal | Total discount in the functional currency | decimal(19,2) |
| DocTypeID | String | Document type identifier | nvarchar(50) |
| DocumentSource | String | Source of the document | nvarchar(25) |
| DueOn\* | String | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| Freight | Decimal | Total freight in the functional currency | decimal(19,2), not null |
| invoiceEntries | [Object](Return%20Line%20Item) | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
| InvoiceNumber\* | String | Invoice number | nvarchar(30) |
| InvoiceType | Int | Invoice type | int, not null |
| Misc | Decimal | Total miscellaneous amount in the functional currency | decimal(19,2) |
| ORIGNUMB | String | Original order number | char(21) |
| ORIGTYPE | Int | Original order type | smallint |
| OriginatingAmount | Decimal | Total order amount in the invoice currency | decimal(19,2) |
| OriginatingBalanceDue | Deciaml | Total balance due in the invoice currency  | decimal(19,2) |
| OriginatingDiscount | Decimal | Total discount in the invoice currency  | decimal(19,2) |
| OriginatingFreight | Decimal | Total freight in the invoice currency  | decimal(19,2) |
| OriginatingMisc | Decimal | Total miscellaneous amount in the invoice currency  | decimal(19,2) |
| OriginatingSubtotal | Decimal | Subtotal in the invoice currency  | decimal(19,2) |
| OriginatingTax | Decimal | Total tax amount in the invoice currency  | decimal(19,2) |
| PONumber | String | Purhcase order number | nvarchar(25) |
| PaymentTerms | String | Payment term | nvarchar(25) |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| ShipToAddress | [Object](Address.md) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| Subtotal | Decimal | Subtotal in the functional currency | decimal(19,2) |
| Tax | Decimal | Total tax amount in the functional currency | decimal(19,2) |
| TermDiscounts | [Object](Term%20Discount.md) | Term discounts |
| Tracking_Number | String | Shipping tracking number| char(41) |
| AgingBucket | Int | Aging bucket number | int |
\*Required
