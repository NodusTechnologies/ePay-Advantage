/// <summary>
/// API Request to get unsubmitted documents on ePay
/// </summary>
/// <param name="URL">URL of the ePay site</param>
/// <param name="unsubmittedDocumentInfo">Unsubmitted document object to get</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="unsubmittedDocumentList">Returned unsubmitted document object</param>
public void GetUnsubmittedDocument(string URL, UnsubmittedDocumentRequest unsubmittedDocumentInfo, EPayToken epayTokenList, ref List<UnsubmittedDocument> unsubmittedDocumentList)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Unsubmitted%20Documents.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/Objects/Unsubmitted%20Document.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/UnsubmittedDocument?" + CreateGetRequestURL(unsubmittedDocumentInfo));
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			unsubmittedDocumentList = deserial.Deserialize<List<UnsubmittedDocument>>(response);
		}
		catch
		{
			unsubmittedDocumentList = null;
		}
	}
	else
		unsubmittedDocumentList = null;
}