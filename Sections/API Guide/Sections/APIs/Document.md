Document
============

The Document API is used to show that a document has been submitted from ePay to another system (such as Microsoft Dynamics GP, AX, or another ERP system). Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Submit a Document Payment
--------------------

* `PUT /document` will update the document's information to show that it has been submitted from the EPay Advantage website based on the JSON request payload

###### Request
<pre>
[
  {
    "ErrorMessage": null,
    "Id": "444202FD-A95A-46C6-9667-5F58134923D5",
    "IsSubmitted": "true"
  }
]
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Document.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>

