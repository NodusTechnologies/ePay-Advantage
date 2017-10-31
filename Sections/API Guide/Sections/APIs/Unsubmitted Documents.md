Unsubmitted Documents
============

The Unsubmitted Document API is used for viewing unsubmitted document payment information on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve Unsubmitted Documents
--------------------

* `GET /UnsubmittedDocument` will get the invoices' header information for a specific customer on the EPay Advantage website based on the URL parameters.

Options
-------

This request accepts the below query string parameters to add options. You can use below query parameters by adding them to your request URL by connecting additional ones with a '&'.

| QueryString | Description | 
| :------------- | :------------- | 
| documentType | Payment type (`7`: Credit Memo, `8`: Return, `9`: Payment) |
| status | Payment status (`0`: scheduled; `1`: submitted; `2`: failed) |
| maxFailedAttempts | Max number of failed attempts the payment has taken to submit to another ERP system |
| pageSize | Max number of payments to be returned |

###### Request
<pre>
  POST /unsubmittedDocument?status=0&pageSize=1
</pre>

###### Response
<pre>
[
  {
    "DocumentDate": "2017-10-31",
    "DocumentNumber": "APIPMT0000000002",
    "DocumentStatus": 0,
    "DocumentType": "9",
    "ErrorMessage": "",
    "FailedAttempts": 0,
    "LastAttempt": "2017-10-25",
    "QueueEntryID": "7fe0b72e-71b6-4bcb-8d9c-245e9df2f082"
  }
]
</pre>
