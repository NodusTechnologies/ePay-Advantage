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
