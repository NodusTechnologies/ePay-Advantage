/// <summary>
/// API Request to create an invoice template on ePay
/// </summary>
/// <param name="json">JSON String</param>
/// <param name="URL">URL for the ePay site</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="responses">Returned response object</param>
public void CreateInvoiceTemplate(string json, string URL, EPayToken epayTokenList, ref CreateResponse responses)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Invoice%20Templates.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/Invoice%20Template.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/invoicetemplate");
	var request = new RestRequest(Method.POST);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	request.AddParameter("application/json", json, ParameterType.RequestBody);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			responses = deserial.Deserialize<CreateResponse>(response);
		}
		catch
		{
			responses.Message = "Token validation failed";
			responses.Result = "false";
		}
	}
	else
	{
		responses.Message = "Bad HTTP Request";
		responses.Result = "false";
	}
}