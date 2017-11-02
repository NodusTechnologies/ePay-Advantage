/// <summary>
/// API Request to create the token value to be used with other API requests
/// </summary>
/// <param name="clientID">Client ID value of the ePay site</param>
/// <param name="secret">Secret value of the ePay stie</param>
/// <param name="URL">URL of the ePay site</param>
/// <param name="epayTokenList">Returned ePay token object</param>
public void CreateToken(string clientID, string secret, string URL, ref EPayToken epayTokenList)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Token.md for more details about request and response.
	// ------------------------------------------------------	
	
	try
	{
		string token = clientID + ":" + secret;
		var tokenPlain = Encoding.UTF8.GetBytes(token);
		string token64 = Convert.ToBase64String(tokenPlain);

		var client = new RestClient(CheckURL(URL) + "API/Token");
		var request = new RestRequest(Method.POST);
		request.AddHeader("content-type", "application/x-www-form-urlencoded");
		request.AddHeader("authorization", "Basic " + token64);
		request.AddParameter("application/x-www-form-urlencoded", "scope=EPayAPIServices&grant_type=client_credentials", ParameterType.RequestBody);
		IRestResponse response = client.Execute(request);
		response.Content = response.Content.Remove(0, 1);

		if (response.StatusCode == System.Net.HttpStatusCode.OK)
		{
			try
			{
				JsonDeserializer deserial = new JsonDeserializer();
				epayTokenList = deserial.Deserialize<EPayToken>(response);
			}
			catch
			{
				epayTokenList = null;
			}
		}
		else
			epayTokenList = null;
	}
	catch
	{
		epayTokenList = null;
	}
}