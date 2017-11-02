/// <summary>
/// API Request to delete a salesperson on ePay
/// </summary>
/// <param name="URL">URL of the ePay site</param>
/// <param name="salesPersonInfo">SalesPerson object to delete</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="responses">Return response object</param>
public void DeleteSalesPerson(string URL, SalesPersonRequest salesPersonInfo, EPayToken epayTokenList, ref CreateResponse responses)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/SalesPersons.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/SalesPerson.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/salesperson?" + CreateGetRequestURL(salesPersonInfo));
	var request = new RestRequest(Method.DELETE);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
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