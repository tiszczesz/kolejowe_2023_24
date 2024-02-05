namespace cw15_form2.Models
{
	public class Welcome
	{
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime DateGo { get; set; }
		public override string ToString()
		{
			return $"{Name}|{Content}|{DateGo}";	
		}
	}
}
