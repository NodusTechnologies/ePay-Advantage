## Unsubmitted Document
EPay Advantage returns the unsubmitted document object which represents a document that has not been submitted to another system.

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
