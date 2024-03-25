
namespace cw15_form2.Models
{
	public class FileRepo
	{

		public static void AddToFile(Welcome welcome, string path = "dane.txt")
		{
			if (welcome != null)
			{
				File.AppendAllText(path, welcome.ToString()+Environment.NewLine);
			}
		}
		public List<Welcome> GetAll(string path="dane.txt"){
			var welcomes = new List<Welcome>();
			List<string> lines = File.ReadAllLines(path).ToList();
			foreach(var line in lines){
				var welcome = Welcome.GetWelocme(line);
				if(welcome!=null) welcomes.Add(welcome);
			}
			return welcomes;
		}

        public void SaveAll(List<Welcome> welcomes,string path="dane.txt")
        {
			//todo zamienic na string
			var lines = new List<string>();
			foreach(var welcome in welcomes){
				lines.Add(welcome.ToString());
			}
            File.WriteAllLines(path,lines);
        }
    }
}
