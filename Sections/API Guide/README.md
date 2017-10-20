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

We have a [detailed guide](Sections/Token.md) for authenticating with the EPay API.


Handling Exceptions
-------------------
EPay uses HTTP response codes to indicate the status of requests. 

We have a [guide](Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
EPay Advantage sends and receives payloads as structured [JSON Objects](Sections/Objects.md). 
Many of these objects are used in both requests and responses. Some of the objects (like Address) are embedded
as child elements of other objects.

### Currency
* [Create a Currency](Sections/Currency.md#create-a-currency)
* [Delete a Currency](Sections/Currency.md#delete-a-currency)

### Customers
* [Create a Customer](Sections/Customers.md#create-a-customer)
* [Update a Customer](Sections/Customers.md#update-a-customer)
* [Retrieve a Customer](Sections/Customers.md#retrieve-a-customer)
* [Retrieve Customers](Sections/Customers.md#retrieve-customers)

### Customer Addresses
* [Create a Customer Address](Sections/Customer%20Addresses.md#create-a-customer-address)
* [Update a Customer Address](Sections/Customer%20Addresses.md#update-a-customer-address)

### Document
* [Submit Document Payment](Sections/Document.md#submit-document-payment)

### Invoices
* [Create an Invoice](Sections/Invoices.md#create-an-invoice)
* [Update an Invoice](Sections/Invoices.md#update-an-invoice)
* [Retrieve an Invoice](Sections/Invoices.md#retrieve-an-invoice)
* [Retrieve Invoices](Sections/Invoices.md#retrieve-invoices)

### Invoice Line Items
* [Create an Invoice Line Item](Sections/Invoice%20Line%20Items.md#create-an-invoice-line-item)
* [Retrieve Invoice Line Items](Sections/Invoice%20Line%20Items.md#retrieve-invoice-line-items)

### Invoice Payments
* [Create an Invoice Payment](Sections/Invoice%20Payments.md#create-an-invoice-payment)
* [Update an Invoice Payment](Sections/Invoice%20Payments.md#update-an-invoice-payment)
* [Retrieve Invoice Payments](Sections/Invoice%20Payments.md#retrieve-invoice-payments)

### Invoice Template
* [Create an Invoice Template](Sections/Invoice%20Templates.md#create-an-invoice-template)
* [Delete an Invoice Template](Sections/Invoice%20Templates.md#delete-an-invoice-template)

### Payments
* [Create a Payment](Sections/Payments.md#create-a-payment)
* [Update a Payment](Sections/Payments.md#update-a-payment)
* [Retrieve a Payment](Sections/Payments.md#retrieve-a-payment)
* [Retrieve Payments](Sections/Payments.md#retrieve-payments)

### PaymentV1
* [Retrieve a Payment and Put Document](Sections/PaymentV1.md#retrieve-a-payment-and-put-document)

### Returns
* [Create a Return](Sections/Returns.md#create-a-return)
* [Update a Return](Sections/Returns.md#update-a-return)

### Return Line Items
* [Create a Return Line Item](Sections/Return%20Line%20Items.md#create-a-return-line-item)
* [Update a Return Line Item](Sections/Return%20Line%20Items.md#update-a-return-line-item)

### SalesPersons
* [Create a SalesPerson](Sections/SalesPersons.md#create-a-salesperson)
* [Delete a SalesPerson](Sections/SalesPersons.md#delete-a-salesperson)

### Settings
* [Create a Setting](Sections/Settings.md#create-a-setting)
* [Update a Setting](Sections/Settings.md#update-a-setting)

### Unsubmitted Documents
* [Retrieve an Unsubmitted Document](Sections/Unsubmitted%20Documents.md#retrieve-an-unsubmitted-document)
* [Retrieve Unsubmitted Documents](Sections/Unsubmitted%20Documents.md#retrieve-unsubmitted-documents)

### Invoice PDFs
* [Upload an Invoice PDF](Sections/InvoicePDFs.md#upload-an-invoice-pdf)


Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@nodus.com>. Also, feel free to branch these documents and send a pull request with improvements!
