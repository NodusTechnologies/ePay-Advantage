/// <summary>
/// Create Get Request to be added to a URL for a request
/// </summary>
/// <param name="cls">Class object</param>
/// <returns></returns>
public string CreateGetRequestURL(object cls)
{
	string restOfURL = "";
	int count = 0;
	PropertyInfo[] properties = cls.GetType().GetProperties();
	foreach (PropertyInfo property in properties)
	{
		if (property.GetValue(cls) != null)
		{
			if (property.GetValue(cls).ToString() != "")
			{
				if (count == 0)
					restOfURL += property.Name.ToString() + "=" + property.GetValue(cls).ToString();
				else
					restOfURL += "&" + property.Name.ToString() + "=" + property.GetValue(cls).ToString();
			}
		}

		count++;
	}
	return restOfURL;
}