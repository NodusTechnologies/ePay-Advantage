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
