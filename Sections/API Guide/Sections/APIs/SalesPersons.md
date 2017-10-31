SalesPersons
============

The SalesPerson API is used for creating, updating and deleting salespeople on the EPay Advantage website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update a SalesPerson
--------------------

* `POST /salesperson` will create or update a salesperson on the EPay Advantage website based on the request JSON payload. If updating an salesperson, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
  "Email": "TEST@nodus.com",
  "Inactive": false,
  "Name": "Test User",
  "SalesPersonID": "TESTCSR",
  "SalesTerritoryID": "TERRITORY 1"
}
</pre>

For more information and descriptions on available fields please see our [object reference](../Objects/SalesPerson.md).

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>


Delete a SalesPerson
--------------------

* `DELETE /salesperson?salespersonid={SalesPersonID}` will delete the salesperson on the EPay Advantage website based on the URL parameter.

###### Request
<pre>
  DELETE /salesperson?salespersonid=TESTCSR
</pre>

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
