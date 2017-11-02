/// <summary>
/// API Request to get the customer on ePay
/// </summary>
/// <param name="URL">URL of the ePay site</param>
/// <param name="customerInfo">Customer Oject to get</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="customerList">Returned customer object</param>
public void GetCustomer(string URL, CustomerRequest customerInfo, EPayToken epayTokenList, ref List<Customer> customerList)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Customers.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/Customer.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/customer?" + CreateGetRequestURL(customerInfo));
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			customerList = deserial.Deserialize<List<Customer>>(response);
		}
		catch
		{
			customerList = null;
		}
	}
	else
		customerList = null;
}