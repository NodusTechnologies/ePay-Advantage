Invoice PDFs
============

The Invoice PDF API is used for uploading invoice pdfs to the EPay Advantage website so that they can be displayed to the customer. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Upload an Inovice PDF
--------------------

* `POST /uploadinvoicepdf?customerNumber={CustomerNumber}&invoiceNumber={InvoiceNumber}&documentDate={DocumentDate}` will upload an invoice PDF to the EPay Advantage website based on the URL parameters. 

###### Request
In the request, all values in the URL are required and make sure to attach the file that you wish to upload as either binary data or application/octet-stream.

###### Response
<pre>
{
  "AdditionalMessage": null,
  "Message": null,
  "Result": true
}
</pre>
