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
