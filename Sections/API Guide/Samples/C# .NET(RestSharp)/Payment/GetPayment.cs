/// <summary>
/// 
/// </summary>
/// <param name="URL">URL of the ePay site</param>
/// <param name="paymentInfo">Payment object to get</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="paymentList">Returned payment object</param>
public void GetPayment(string URL, PaymentRequest paymentInfo, EPayToken epayTokenList, ref GetPayment paymentList)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Payments.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/Payment.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/payment?" + CreateGetRequestURL(paymentInfo));
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			paymentList = deserial.Deserialize<GetPayment>(response);
		}
		catch
		{
			paymentList = null;
		}
	}
	else
		paymentList = null;
}