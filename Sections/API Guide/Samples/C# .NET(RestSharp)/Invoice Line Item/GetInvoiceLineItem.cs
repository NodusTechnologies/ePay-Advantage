/// <summary>
/// API Request to get the invoice line items on ePay
/// </summary>
/// <param name="URL">URL of the ePay site</param>
/// <param name="invoiceEntryInfo">Invoice object associated to the line items</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="invoiceEntryList">Returned invoice line item object</param>
public void GetInvoiceEntries(string URL, InvoiceLineItemRequest invoiceEntryInfo, EPayToken epayTokenList, ref GetInvoiceLineItem invoiceEntryList)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Invoice%20Line%20Items.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/Invoice%20Line%20Item.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/invoiceLineItem?" + CreateGetRequestURL(invoiceEntryInfo));
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			invoiceEntryList = deserial.Deserialize<GetInvoiceLineItem>(response);
		}
		catch
		{
			invoiceEntryList = null;
		}
	}
	else
		invoiceEntryList = null;
}