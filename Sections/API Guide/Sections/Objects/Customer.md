## Customer
Customer object represents a customer that can be invoice'd and make payments on the EPay Advantage website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](Address.md) | Address object |
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
| PaymentMethod | String | Available payment method the customer can use. Available values are 'All', 'CC', 'eCheck' and 'None' | nvarchar(25) |
| PaymentTerms | String | Payment term | nvarchar(25) |
| PriceLevel | String | Price level | varchar(50) |
| PrimaryAddress | [Object](Address.md) | Address object |
| SalesPersonID | String | SalesPerson number | nvarchar(25) |
| SalesTerritoryID | String | Territory name | nvarchar(25) |
| ShippingAddress | [Object](Address.md) | Address object |
| ShippingMethod | String | Shipping method name | varchar(100) |
| StatementName | String | Statement name | nvarchar(255) |
| TaxExempt | Boolean | Indicates if the customer will be charged tax | bit |
| TaxScheduleID | String | Tax schedule | nvarchar(25) |
| TradeDiscount | Float | Customer discount | Float |
| UserDefine1 | String | User-defined field 1. Developer can store additional data in this field. | nvarchar(255) |
| UserDefine2 | String | User-defined field 2. Developer can store additional data in this field. | nvarchar(255) |
\*Required
