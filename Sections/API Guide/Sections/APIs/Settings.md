Settings
============

The Settings API is used for creating, and updating settings on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Invoice
--------------------

* `POST /setting` will create or update a setting on the EPay Advantage website based on the JSON request payload. If updating a setting, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
[
  {
    <b>"Name": "TestSetting"</b>,
    <b>"Value": "Hello World"</b>
  }
]
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../Objects/Setting.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>

