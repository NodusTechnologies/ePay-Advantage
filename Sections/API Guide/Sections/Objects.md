# API JSON Objects
EPay Advantage uses JSON objects to send and receive client data. This is the official reference documentation for JSON objects used in the EPay Advantage REST API.

## Address
Address object represents the shipping or billing address of a customer. This object may be included as a child attribute of other JSON objects (such as [Customer](#customer)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Address1 | String | The first line of a street address | nvarchar(200) |
| Address2 | String | The second line of a street address | nvarchar(200) |
| Address3 | String | The third line of a street address | nvarchar(200) |
| AddressID\* | String | The address identifier | nvarchar(25) |
| City | String | City name | nvarchar(100) |
| Country | String | Country name | nvarchar(100) |
| CustomerNumber\* | String | Customer ID specified by the client | nvarchar(25) |
| EMailAddress | String | Email address | nvarchar(200) |
| Fax | String | Fax number | nvarchar(21) |
| Name | String | Customer name | nvarchar(255) |
| Phone1 | String | Phone number line 1 | nvarchar(21) |
| Phone2 | String | Phone number line 2 | nvarchar(21) |
| Phone3 | String | Phone number line 3 | nvarchar(21) |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| State | String | State name | nvarchar(100) |
| TaxScheduleID | String | Tax schedule | nvarchar(25) |
| TerritoryID | String | Territory name | nvarchar(25) |
| UPSZone | String | UPS zone | nvarchar(50) |
| UserDefine1 | String | User-defined field 1. Developer can store additional data in this field. | nvarchar(255) |
| UserDefine2 | String | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
| Zip | String | Zip code | nvarchar(20) |
\*Required

## Currency
Currency object represents a valid currency to be used in EPay Advantage. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CurrencyID\* | String | Currency code | nvarchar(25) |
| CurrencyIndex | String | Unique value associated with the currency  | nvarchar(25) |
| Description | String | Description of the currency | nvarchar(50) |
| IsFuncCurrency | Boolean | Indicates if the currency will be used as the main currency | bit |
| Symobl | String | Currency symbol | nvarchar(10) |
\*Required

## Customer
Customer object represents a customer to be invoice and can make payments on the EPay Advantage site.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](#address) | Address object |
| ClassID | String | Class associated to a customer | varchar(50) |
| Comment1 | String | Comment line 1 field | nvarchar(200) |
| Comment2 | String | Comment line 2 field | nvarchar(25) |
| CreditLimitAmount | Decimal | Credit limit amount | decimal(19,2) |
| CreditLimitType | Int | Credit limit type | int, not null |
| CurrencyID | String | Currency code | nvarchar(25) |
| CustomerNumber\* | String | Customer ID specified by the client | nvarchar(25) |
| Email | String | Email address | nvarchar(200) |
| Inactive | Boolean | Indicates if the customer should be marked as inactive | bit |
| Name | String | Customer name | nvarchar(65) |
| OnHold | Boolean | Indicates if the customer should be marked as on hold | bit |
| ParentCustomerNumber | String | Parent customer number | nvarchar(25) |
| PaymentTerms | String | Payment term | nvarchar(25) |
| PriceLevel | String | Price level | varchar(50) |
| PrimaryAddress | [Object](#address) | Address object |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| SalesTerritoryID | String | Territory name | nvarchar(25) |
| ShippingAddress | [Object](#address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| StatementName | String | Statement name | nvarchar(255) |
| TaxExempt | Boolean | Indicates if the customer will be charged tax | bit |
| TaxScheduleID | String | Tax schedule | nvarchar(25) |
| TradeDiscount | Float | Customer discount | Float |
| UserDefine1 | String | User-defined field 1. Developer can store additional data in this field. | nvarchar(255) |
| UserDefine2 | String | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
\*Required

## Document
Document object represents an update to a document to show the document as submitted / completed from EPay Advantage to another system

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| ErrorMessage | String | Error message to be displayed onto the document to show the document as not submitted | nvarchar(25) |
| ID | String | Document number  | nvarchar(50) |
| IsSubmitted | Boolean | Indicates if the document will show as submitted | bit |

## Invoice
Invoice object represents an invoice to be paid on the EPay Advantage site

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
| invoiceEntries | [Object](#invoice%20line%20item) | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
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
| ShipToAddress | [Object](#address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| Subtotal | Decimal | Subtotal in the functional currency | decimal(19,2) |
| Tax | Decimal | Total tax amount in the functional currency | decimal(19,2) |
| TermDiscounts | [Object](#term%20discount) | Term discounts |
| Tracking_Number | String | Shipping tracking number| char(41) |
\*Required

## Invoice Line Item
Invoice line item object represents a line item to be associated to an invoice. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Invoice](#invoice)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Description | String | Description of the item | nvarchar(101) |
| ExtendedPrice | Decimal | Extended price in the functional currency | decimal(19,2) |
| InvoiceNumber | String | Invoice number | nvarchar(30) |
| InvoiceType | Int | Invoice type | int |
| ItemCode | String | Item code | nvarchar(50) |
| Markdown | Decimal | Markdown amount in the functional currency | decimal(19,5) |
| MarkdownPercentage | Decimal | Markdown percentage | decimal(19,5) |
| NonInventory | Boolean | Indicates if the item is a valid predefined item | bit |
| OriginatingExtendedPrice | Decimal | Extended price in the invoice currency | decimal(19,2) |
| OriginatingMarkdown | Decimal | Markdown amount in the invoice currency | decimal(19,5) |
| OriginatingTaxAmount | Decimal | Tax amount in the invoice currency | decimal(19,2) |
| OriginatingUnitPrice | Decimal | Unit price in the invoice currency | decimal(19,5) |
| PriceLevel | String | Price level | varchar(50) |
| Quantity | Decimal | Number of quantity | decimal(19,2) |
| ReqShipDate\* | String | Timestamp indicating when this item is required to ship. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| Sequence | Int | Line item number identifier | int |
| ShipToAddress | [Object](#address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| TaxAmount | Deciaml | Tax amount in the functional currency | decimal(19,2) |
| Taxable | Boolean | Indicates if the item is taxable | bit |
| UnitOfMeasure | String | Unit of measure | nvarchar(25) |
| UnitPrice | Decimal | Unit price in the functional currency | decimal(19,2) |
\*Required

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

## Invoice Template
Invoice template object represents the template to be used for invoices when view them on the EPay Advantage site.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| GroupVars | String | Source of the document | nvarchar(max) |
| LineItems | String | Line item section | nvarchar(max) |
| Locked | Boolean | Indicates if the template can be edited | bit |
| MainBody | String | Main body section | nvarchar(max) |
| Name\* | String | Invoice template name | nvarchar(100) |
| Payments | String | Applied payment section | nvarchar(max) |
\*Required

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
| InvoicePayments | [Object](#invoice%20payment) | Invoice payment object |
| IsVoid | Boolean | Indicates if the payment is voided | bit |
| OriginatingAmount | Decimal | Total payment amount in the payment currency | decimal(19,2) |
| OriginatingBalanceAmount | Deciaml | Total balance amount in the payment currency  | decimal(19,2) |
| PaymentNumber\* | String | Payment number | nvarchar(25) |
| PaymentType | Int | Payment type (7 = Credit Memo, 8 = Return, 9 = Payment) | int |
\*Required

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
| invoiceEntries | [Object](#return%20line%20item) | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
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
| ShipToAddress | [Object](#address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| Subtotal | Decimal | Subtotal in the functional currency | decimal(19,2) |
| Tax | Decimal | Total tax amount in the functional currency | decimal(19,2) |
| TermDiscounts | [Object](#term%20discount) | Term discounts |
| Tracking_Number | String | Shipping tracking number| char(41) |
| AgingBucket | Int | Aging bucket number | int |
\*Required

## Return Line Item
Return line item object represents the line item on a return that can be seen in the EPay Advantage site. This object may be included as a child attribute of other JSON objects (such as [Return](#return)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Description | String | Description of the item | nvarchar(101) |
| ExtendedPrice | Decimal | Extended price in the functional currency | decimal(19,2) |
| InvoiceNumber | String | Invoice number | nvarchar(30) |
| InvoiceType | Int | Invoice type | int |
| ItemCode | String | Item code | nvarchar(50) |
| Markdown | Decimal | Markdown amount in the functional currency | decimal(19,5) |
| MarkdownPercentage | Decimal | Markdown percentage | decimal(19,5) |
| NonInventory | Boolean | Indicates if the item is a valid predefined item | bit |
| OriginatingExtendedPrice | Decimal | Extended price in the invoice currency | decimal(19,2) |
| OriginatingMarkdown | Decimal | Markdown amount in the invoice currency | decimal(19,5) |
| OriginatingTaxAmount | Decimal | Tax amount in the invoice currency | decimal(19,2) |
| OriginatingUnitPrice | Decimal | Unit price in the invoice currency | decimal(19,5) |
| PriceLevel | String | Price level | varchar(50) |
| Quantity | Decimal | Number of quantity | decimal(19,2) |
| ReqShipDate\* | String | Timestamp indicating when this item is required to ship. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| Sequence | Int | Line item number identifier | int |
| ShipToAddress | [Object](#address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| TaxAmount | Deciaml | Tax amount in the functional currency | decimal(19,2) |
| Taxable | Boolean | Indicates if the item is taxable | bit |
| UnitOfMeasure | String | Unit of measure | nvarchar(25) |
| UnitPrice | Decimal | Unit price in the functional currency | decimal(19,2) |
\*Required

## SalesPerson
SalesPerson object represents the salesperson that can be setup in the EPay Advantage site.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Email | String | Email address | nvarchar(200) |
| Inactive | Boolean | Indicates if the salesperson is inactive | bit |
| Name | String | Salesperson's name | nvarchar(25) |
| SalesPersonID | String | Salesperson number or ID | nvarchar(25) |
| SalesTerritoryID | String | Salesperson's territory | nvarchar(25) |

## Setting
Setting object represents a setting that can be changed or inserted into the EPay Advantage site.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Name\* | String | Setting name | nvarchar(50) |
| Value\* | String | Setting value | ntext |
\*Required

## Term Discount
Term discount object represents a discount to be applied to an invoice if it is paid within the term alloted. This object will be included as a child attribute of other JSON objects (such as [Invoice](#invoice) and [Return](#return)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| DiscardDate\* | String | Timestamp indicating when this discount should be discarded. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| DiscountAvaialableAmount | Decimal | Available discount amount | decimal(19,5) |
\*Required

## Unsubmitted Document
EPay Advantage returns the unsubmitted document object which represents a document that has not been submitted to another ERP system.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| DocumentDate | String | Timestamp indicating the date of the document. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| DocumentNumber | String | Document number | nvarchar(50) |
| DocumentStatus | Int | Document status | int |
| DocumentType | Int | Document type | int |
| ErrorMessage | String | Error message | ntext |
| FailedAttempts | Int | Failed attempts counter | int |
| LastAttempt | String | Last attempt date | datetime |
| QueueEntryID | GUID | Document queue entry unique identifier | 36 |
