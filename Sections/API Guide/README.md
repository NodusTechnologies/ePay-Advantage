API Guide
==============
EPay Advantage APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below is the API endpoint:

``http://<EPay Advatange Site URL>/api``

Where do I start?
-----------------

Want to get started with EPay Advantage API integration? Here's a quick check list:

1. Install and configure your own EPay Advantage site to be used with the APIs.
2. Read up on how to [authenticate](#authentication) with the APIs. 
3. Read up on how to [handle errors](#handling-exceptions) with the APIs.
4. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](Samples).
5. Have a question or need help? Contact <support@nodus.com>.


Authentication
--------------
All EPay Advantage API calls need a header containing the authorization token

We have a [detailed guide](Sections/APIs/Token.md) for authenticating with the EPay Advantage API.


Handling Exceptions
-------------------
EPay uses HTTP response codes to indicate the status of requests. 

We have a [guide](Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
EPay Advantage sends and receives payloads as structured [JSON Objects](Sections/Objects). 
Many of these objects are used in both requests and responses. Some of the objects (like Address) are embedded
as child elements of other objects.

### Currency
* [Create a Currency](Sections/APIs/Currency.md#create-a-currency)
* [Delete a Currency](Sections/APIs/Currency.md#delete-a-currency)

### Customers
* [Create or Update a Customer](Sections/APIs/Customers.md#create-or-update-a-customer)
* [Retrieve Customers](Sections/APIs/Customers.md#retrieve-customers)

### Customer Addresses
* [Create or Update a Customer Address](Sections/APIs/Customer%20Addresses.md#create-or-update-a-customer-address)
* [Update a Customer Address](Sections/APIs/Customer%20Addresses.md#update-a-customer-address)

### Document
* [Submit Document Payment](Sections/APIs/Document.md#submit-document-payment)

### Invoices
* [Create or Update an Invoice](Sections/APIs/Invoices.md#create-or-update-an-invoice)
* [Retrieve Invoices](Sections/APIs/Invoices.md#retrieve-invoices)

### Invoice Line Items
* [Create or Update an Invoice Line Item](Sections/APIs/Invoice%20Line%20Items.md#create-or-update-an-invoice-line-item)
* [Retrieve Invoice Line Items](Sections/APIs/Invoice%20Line%20Items.md#retrieve-invoice-line-items)

### Invoice Payments
* [Create or Update an Invoice Payment](Sections/APIs/Invoice%20Payments.md#create-or-update-an-invoice-payment)
* [Retrieve Invoice Payments](Sections/APIs/Invoice%20Payments.md#retrieve-invoice-payments)

### Invoice Template
* [Create or Update an Invoice Template](Sections/APIs/Invoice%20Templates.md#create-or-update-an-invoice-template)
* [Delete an Invoice Template](Sections/APIs/Invoice%20Templates.md#delete-an-invoice-template)

### Payments
* [Create or Update a Payment](Sections/APIs/Payments.md#create-or-update-a-payment)
* [Retrieve Payments](Sections/APIs/Payments.md#retrieve-payments)

### Returns
* [Create or Update a Return](Sections/APIs/Returns.md#create-or-update-a-return)

### Return Line Items
* [Create or Update a Return Line Item](Sections/APIs/Return%20Line%20Items.md#create-or-update-a-return-line-item)

### SalesPersons
* [Create a SalesPerson](Sections/APIs/SalesPersons.md#create-a-salesperson)
* [Delete a SalesPerson](Sections/APIs/SalesPersons.md#delete-a-salesperson)

### Settings
* [Create or Update a Setting](Sections/APIs/Settings.md#create-or-update-a-setting)

### Unsubmitted Documents
* [Retrieve Unsubmitted Documents](Sections/APIs/Unsubmitted%20Documents.md#retrieve-unsubmitted-documents)

### Invoice PDFs
* [Upload an Invoice PDF](Sections/APIs/InvoicePDFs.md#upload-an-invoice-pdf)


Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@nodus.com>. Also, feel free to branch these documents and send a pull request with improvements!
