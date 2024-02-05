namespace cw15_form2.Models
{
	public class FileRepo
	{
		public static void AddToFile(Welcome welcome, string path = "dane.txt")
		{
			if (welcome != null)
			{
				File.AppendAllText(path, welcome.ToString());
			}
		}
	}
}
