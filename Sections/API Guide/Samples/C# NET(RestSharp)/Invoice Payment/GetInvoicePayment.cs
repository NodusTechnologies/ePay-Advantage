/// <summary>
/// API Request to get the record for the payment applied to an invoice on ePay
/// </summary>
/// <param name="URL">URL of the ePay site</param>
/// <param name="invoicePaymentInfo">Invoice Payment object to get</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="invoicePaymentList">Returned invoice payment object</param>
public void GetInvoicePayment(string URL, InvoicePaymentRequest invoicePaymentInfo, EPayToken epayTokenList, ref GetInvoicePayment invoicePaymentList)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Invoice%20Payments.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/Invoice%20Payment.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/invoicepayment?" + CreateGetRequestURL(invoicePaymentInfo));
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			invoicePaymentList = deserial.Deserialize<GetInvoicePayment>(response);
		}
		catch
		{
			invoicePaymentList = null;
		}
	}
	else
		invoicePaymentList = null;
}