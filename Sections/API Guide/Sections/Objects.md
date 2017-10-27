# API JSON Objects
EPay Advantage uses JSON objects to send and receive client data. This is the official reference documentation for JSON objects used in the EPay Advantage REST API.

## Address
Address object represents the shipping or billing address of a customer. This object may be included as a child attribute of other JSON objects (such as [Customer](#Customer)).

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
| IsFuncCurrency | Boolean | If true, the currency will be used as the main currency | bit, not null |
| Symobl | String | Currency symbol | nvarchar(10) |
\*Required

## Customer
Customer object represents a customer to be invoice and can make payments on the EPay Advantage site.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](#Address) | Address object |
| ClassID | String | Class associated to a customer | varchar(50) |
| Comment1 | String | Comment line 1 field | nvarchar(200) |
| Comment2 | String | Comment line 2 field | nvarchar(25) |
| CreditLimitAmount | Decimal | Credit limit amount | decimal(19,2), not null |
| CreditLimitType | Int | Credit limit type | int, not null |
| CurrencyID | String | Currency code | nvarchar(25) |
| CustomerNumber\* | String | Customer ID specified by the client | nvarchar(25) |
| Email | String | Email address | nvarchar(200) |
| Inactive | Boolean | If true, customer will be marked as inactive | bit, not null |
| Name | String | Customer name | nvarchar(65) |
| OnHold | Boolean | If true, customer will be marked as on hold | bit, not null |
| ParentCustomerNumber | String | Parent customer number | nvarchar(25) |
| PaymentTerms | String | Payment term | nvarchar(25) |
| PriceLevel | String | Price level | varchar(50) |
| PrimaryAddress | [Object](#Address) | Address object |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| SalesTerritoryID | String | Territory name | nvarchar(25) |
| ShippingAddress | [Object](#Address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| StatementName | String | Statement name | nvarchar(255) |
| TaxExempt | Boolean | If true, customer will not be charged tax | bit, not null |
| TaxScheduleID | String | Tax schedule | nvarchar(25) |
| TradeDiscount | Float | Customer discount | Float, not null |
| UserDefine1 | String | User-defined field 1. Developer can store additional data in this field. | nvarchar(255) |
| UserDefine2 | String | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
\*Required

## Document
Document object represents an update to a document to show the document as submitted / completed from EPay Advantage to another system

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| ErrorMessage | String | Error message to be displayed onto the document to show the document as not submitted | nvarchar(25) |
| ID | String | Document number  | nvarchar(50) |
| IsSubmitted | Boolean | If true, the document will show as submitted | bit, not null |

## Invoice
Invoice object represents an invoice to be paid on the EPay Advantage site

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total invoice amount | decimal(19,2), not null |
| BalanceDue | Decimal | Balance due | decimal(19,2), not null |
| BatchNumber | String | Batch number | nvarchar(25) |
| BillingAddressName | String | Billing address identifier | nvarchar(25) |
| Comments | String | Additional comments | nvarchar(4000) |
| CreatedOn | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime, not null |
| CurrencyID | String | Currency code | nvarchar(25) |
| CustomerNumber\* | String | Customer ID specified by the client | nvarchar(25) |
| Discount | Decimal | Total discount | decimal(19,2), not null |
| DocTypeID | String | Document type identifier | nvarchar(50) |
| DocumentSource | String | Source of the document | nvarchar(25) |
| DueOn | String | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime, not null |
| Freight | Decimal | Total freight | decimal(19,2), not null |
| invoiceEntries | [Object](#Invoice%20Line%20Item) | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
| InvoiceNumber\* | String | Invoice number | nvarchar(30) |
| InvoiceType | Int | Invoice type | int, not null |
| Misc | Decimal | Total miscellaneous charge | decimal(19,2), not null |
| ORIGNUMB | String | Original order number | char(21) |
| ORIGTYPE | Int | Original order type | smallint, not null |
| OriginatingAmount | Decimal | Original total order amount | decimal(19,2), not null |
| OriginatingBalanceDue | Deciaml | Original balance due | decimal(19,2), not null |
| OriginatingDiscount | Decimal | Original total discount | decimal(19,2), not null |
| OriginatingFreight | Decimal | Original total freight | decimal(19,2), not null |
| OriginatingMisc | Decimal | Original total miscellaneous charge | decimal(19,2), not null |
| OriginatingSubtotal | Decimal | Original subtotal | decimal(19,2), not null |
| OriginatingTax | Decimal | Original total tax amount | decimal(19,2), not null |
| PONumber | String | Purhcase order number | nvarchar(25) |
| PaymentTerms | String | Payment term | nvarchar(25) |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| ShipToAddress | [Object](#Address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| Subtotal | Decimal | Subtotal | decimal(19,2), not null |
| Tax | Decimal | Total tax amount | decimal(19,2), not null |
| TermDiscounts | [Object](#Term%20Discount) | Term discounts |
| Tracking_Number | String | Shipping tracking number| char(41) |
\*Required

## Invoice Line Item
Invoice line item object represents a line item to be associated to an invoice. This object may be included as a child attribute of other JSON objects (such as [Invoice](#Invoice)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Description | String | Description of the item | nvarchar(101) |
| ExtendedPrice | Decimal | Extended price | decimal(19,2), not null |
| InvoiceNumber | String | Invoice number | nvarchar(30) |
| InvoiceType | Int | Invoice type | int, not null |
| ItemCode | String | Item code | nvarchar(50) |
| Markdown | Decimal | Markdown amount | decimal(19,5) |
| MarkdownPercentage | Decimal | Markdown percentage | decimal(19,5) |
| NonInventory | Boolean | If true, the item is a valid predefined item | bit, not null |
| OriginatingExtendedPrice | Decimal | Original extended price | decimal(19,2), not null |
| OriginatingMarkdown | Decimal | Original markdown amount | decimal(19,5), not null |
| OriginatingTaxAmount | Decimal | Original tax amount | decimal(19,2), not null |
| OriginatingUnitPrice | Decimal | Original unit price | decimal(19,5), not null |
| PriceLevel | String | Price level | varchar(50) |
| Quantity | Decimal | Number of quantity | decimal(19,2), not null |
| ReqShipDate | String | Timestamp indicating when this item is required to ship. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime, not null |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| Sequence | Int | Line item number | int, not null |
| ShipToAddress | [Object](#Address) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| SiteID | String | Ship from site / warehouse | nvarchar(25) |
| TaxAmount | Deciaml | Tax amount | decimal(19,2), not null |
| Taxable | Boolean | If true, item is taxable | bit, not null |
| UnitOfMeasure | String | Unit of measure | nvarchar(25) |
| UnitPrice | Decimal | Unit price | decimal(19,2), not null |
\*Required



