/// <summary>
/// API Request to create an invoice PDF on ePay
/// </summary>
/// <param name="fileName">File name of the file to be created</param>
/// <param name="filePathAndName">File path and name of the file to be creted</param>
/// <param name="URL">URL of the ePay site</param>
/// <param name="invoicePDFInfo">Invoice PDF object</param>
/// <param name="epayTokenList">ePay token object</param>
/// <param name="responses">Returned response object</param>
public void CreateInvoicePDF(string fileName, string filePathAndName, string URL, InvoicePDFRequest invoicePDFInfo, EPayToken epayTokenList, ref CreateResponse responses)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Invoice%20PDFs.md for more details about request and response.
	// ------------------------------------------------------
	
	var client = new RestClient(CheckURL(URL) + "API/uploadinvoicepdf?" + CreateGetRequestURL(invoicePDFInfo));
	var request = new RestRequest(Method.POST);
	request.AddHeader("authorization", "Bearer " + epayTokenList.access_token);
	request.AddFile(fileName, filePathAndName, "application/octet-stream");
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