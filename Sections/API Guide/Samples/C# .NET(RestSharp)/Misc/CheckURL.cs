/// <summary>
/// Checks the URL to see if it has http or not, or if it has a '/' at the end
/// </summary>
/// <param name="URL">A URL string</param>
/// <returns></returns>
private string CheckURL(string URL)
{
	if (URL[URL.Length - 1] != '/')
		URL += '/';

	if (URL.Substring(0, 7) != "http://" && URL.Substring(0, 8) != "https://")
		URL = "http://" + URL;

	return URL;
}