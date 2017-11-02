/// <summary>
/// API Request to get the invoice on ePay
/// </summary>
/// <param name="URL">URL of the ePay site</param>
/// <param name="invoiceInfo">Invoice object to get</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="invoiceList">Returned invoice object</param>
public void GetInvoice(string URL, InvoiceRequest invoiceInfo, EPayToken epayTokenList, ref GetInvoice invoiceList)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Invoices.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/Invoice.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/invoice?" + CreateGetRequestURL(invoiceInfo));
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			invoiceList = deserial.Deserialize<GetInvoice>(response);
		}
		catch
		{
			invoiceList = null;
		}
	}
	else
		invoiceList = null;
}