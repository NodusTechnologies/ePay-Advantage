## Autopay
Autopay object represents an autopay contract associated to the customer.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AccountType | String | Used to specify the account type to pay when using Parent-Child relationships. This can be "Main", "All", or "Selected". Will use "All" if blank or null |
| Accounts | Array of Strings | Specify the customer number to pay when using Parent-Child relationships. Required if using "Selected" for AccountType |
| Amount | Decimal | Amount to be charged. Required if using "FixedAmount" for PaymentOption. | Decimal(19, 2) |
| ContractDescription | String | Description for the contract | nvarchar(100) |
| ContractNumber | String | Number to be used for the contract. Will be generated if blank or null | nvarchar(20) |
| CreatedOn | DateTime | Date the contract was created on. Will use current date if blank or null | DateTime |
| Currency | String | Currency to be used for the contract. Will use customer's default if blank or null | nvarchar(25) |
| CustomerNumber\* | String | Customer ID specified by the client | nvarchar(25) |
| EndDate | DateTime | Date in which the contract should close. Required if using "Date" for EndType | DateTime |
| EndType | String | When the contract should end. This can be "None", "Occurrences", or "Date". will use "None" if blank or null |
| Frequency\* | String | Frequency of the contract. This can be "Daily", "Weekly", "BiWeekly", "Monthly", "Quarterly", or "Annually" |
| MaxOccurrences | int | Max number of occurrences the contract will run before closing. Required if using "Occurrences" for EndType | int |
| NextPaymentDate\*\* | DateTime | Next date in which the contract should process | DateTime |
| PaymentMethod\* | String | Payment method to be used with the contract. This can either be the Wallet Entry ID, or you can choose "CC" or "eCheck" to get the customer's default wallet or latest wallet |
| PaymentOption\*\* | String | Payment option to be used with the contract. This can be "FixedAmount", "BasedOnDueDate", "BasedOnDocDate", "AllOutstanding" |
| ProcessOnDay | int | Day in which the contract will process. If using "Weekly" or "BiWeekly", the range is between 0 (Sunday) and 6 (Saturday). Anything else will be a range between 1 and 31. Will be calculated if null | int |
| StartDate | DateTime | Date the contract will start on. Will use current date if blank or null | DateTime |
| Status | String | Status of the contract. This can be "Active", "Closed", or "OnHold". Will use "Active" if blank or null |
\*Required  
\**Required only for new contracts  