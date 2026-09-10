namespace PrelinqDemo;

public static class DateTimeExtensions
{
	// nieuwe - 2025

	extension(DateTime)
	{
		public static void Whoa()
		{
			
		}
	}
	
	extension(DateTime dt)
	{
		public string ToMyPrettyString2()
		{
			return dt.ToString("d-m-Y");
		}
		
		public string ToMyPrettyString3()
		{
			return "hoi";
		}
		
		public string ToMyPrettyString4()
		{
			return "hoi";
		}
	}
	
	// oude
	public static string ToMyPrettyString(this DateTime dt)
	{
		
	}
}