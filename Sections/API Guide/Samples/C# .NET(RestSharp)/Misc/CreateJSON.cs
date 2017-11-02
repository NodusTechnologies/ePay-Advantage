/// <summary>
/// Create the JSON object from a class
/// </summary>
/// <param name="cls">Class object</param>
/// <returns></returns>
public string CreateJSON(object cls)
{
	string json = string.Empty;

	JsonSerializer serial = new JsonSerializer();
	json = serial.Serialize(cls);

	return json;
}
