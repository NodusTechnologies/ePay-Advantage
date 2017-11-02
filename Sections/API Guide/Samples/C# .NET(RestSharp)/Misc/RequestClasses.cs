public class CurrencyRequest
{
	public string CurrencyID { get; set; }
}

public class CustomerRequest
{
	public string CustomerNumber { get; set; }
	public string Name { get; set; }
}

public class InvoiceRequest
{
	public string CustomerNumber { get; set; }
	public string Posted { get; set; }
	public string StartDate { get; set; }
}

public class InvoiceLineItemRequest
{
	public string InvoiceNumber { get; set; }
	public string Identity { get; set; }
}

public class InvoicePaymentRequest
{
	public string PaymentNumber { get; set; }
}

public class InvoiceTemplateRequest
{
	public string Name { get; set; }
}

public class PaymentRequest
{
	public string Status { get; set; }
	public string CustomerNumber { get; set; }
	public string PaymentNumber { get; set; }
	public string Type { get; set; }
	public string StartDate { get; set; }
	public string EndDate { get; set; }
	public string MasterType { get; set; }
	public string Currency { get; set; }
	public string PageSize { get; set; }
}

public class ReturnsLineItemRequest
{
	public string InvoiceNumber { get; set; }
	public string Identity { get; set; }
}

public class SalesPersonRequest
{
	public string SalesPersonID { get; set; }
}

public class UnsubmittedDocumentRequest
{
	public string DocumentType { get; set; }
	public string Status { get; set; }
	public string MaxFailedAttempts { get; set; }
	public string PageSize { get; set; }
}