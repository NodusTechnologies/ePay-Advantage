API Guide
==============
EPay APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below is the API endpoint:

``http://<EPay Site URL>/api``

Where do I start?
-----------------

Want to get started with EPay API integration? Here's a quick check list:

1. Install and configure your own EPay site to be used with the APIs.
2. Read up on how to [authenticate](#authentication) with the APIs. 
3. Read up on how to [handle errors](#handling-exceptions) with the APIs.
4. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](Samples).
5. Have a question or need help? Contact <support@nodus.com>.


Authentication
--------------
All EPay API calls need a header containing the authorization token

We have a [detailed guide](Sections/Authentication.md) for authenticating with the EPay API.


Handling Exceptions
-------------------
EPay uses HTTP response codes to indicate the status of requests. 

We have a [guide](Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
EPay sends and receives payloads as structured [JSON Objects](Sections/Objects.md). 
Many of these objects are used in both requests and responses. Some of the objects (like Address) are embedded
as child elements of other objects.

### Currency
* [Create a Currency](Sections/Transactions.md#create-a-currency)
* [Delete a Currency](Sections/Transactions.md#delete-a-currency)

### Customers
* [Create a Customer](Sections/Transactions.md#create-a-customer)
* [Update a Customer](Sections/Transactions.md#update-a-customer)
* [Retrieve a Customer](Sections/Transactions.md#retrieve-a-customer)
* [Retrieve Customers](Sections/Transactions.md#retrieve-customers)

### Customer Addresses
* [Create a Customer Address](Sections/Transactions.md#create-a-customer-address)
* [Update a Customer Address](Sections/Transactions.md#update-a-customer-address)

### Document
* [Submit Document Payment](Sections/Transactions.md#submit-document-payment)

### Invoices
* [Create an Invoice](Sections/Transactions.md#create-an-invoice)
* [Update an Invoice](Sections/Transactions.md#update-an-invoice)
* [Retrieve an Invoice](Sections/Transactions.md#retrieve-an-invoice)
* [Retrieve Invoices](Sections/Transactions.md#retrieve-invoices)

### Invoice Line Items
* [Create an Invoice Line Item](Sections/Transactions.md#create-an-invoice-line-item)
* [Retrieve Invoice Line Items](Sections/Transactions.md#retrieve-invoice-line-items)

### Invoice Payments
* [Create an Invoice Payment](Sections/Transactions.md#create-an-invoice-payment)
* [Update an Invoice Payment](Sections/Transactions.md#update-an-invoice-payment)
* [Retrieve Invoice Payments](Sections/Transactions.md#retrieve-invoice-payments)

### Invoice Template
* [Create an Invoice Template](Sections/Transactions.md#create-an-invoice-template)
* [Delete an Invoice Template](Sections/Transactions.md#delete-an-invoice-template)

### Payments
* [Create a Payment](Sections/Transactions.md#create-a-payment)
* [Update a Payment](Sections/Transactions.md#update-a-payment)
* [Retrieve a Payment](Sections/Transactions.md#retrieve-a-payment)
* [Retrieve Payments](Sections/Transactions.md#retrieve-payments)

### PaymentV1
* [Retrieve a Payment and Put Document](Sections/Transactions.md#retrieve-a-payment-and-put-document)

### Returns
* [Create a Return](Sections/Transactions.md#create-a-return)
* [Update a Return](Sections/Transactions.md#update-a-return)

### Return Line Items
* [Create a Return Line Item](Sections/Transactions.md#create-a-return-line-item)
* [Update a Return Line Item](Sections/Transactions.md#update-a-return-line-item)

### SalesPersons
* [Create a SalesPerson](Sections/Transactions.md#create-a-salesperson)
* [Delete a SalesPerson](Sections/Transactions.md#delete-a-salesperson)

### Settings
* [Create a Setting](Sections/Transactions.md#create-a-setting)
* [Update a Setting](Sections/Transactions.md#update-a-setting)

### Unsubmitted Documents
* [Retrieve an Unsubmitted Document](Sections/Transactions.md#retrieve-an-unsubmitted-document)
* [Retrieve Unsubmitted Documents](Sections/Transactions.md#retrieve-unsubmitted-documents)

### Invoice PDFs
* [Upload an Invoice PDF](Sections/Transactions.md#upload-an-invoice-pdf)

Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@nodus.com>. Also, feel free to branch these documents and send a pull request with improvements!
