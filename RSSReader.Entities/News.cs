using System;

namespace RSSReader.Entities
{
	public class News
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Text { get; set; }
		public DateTime? Date { get; set; }
		public string ImgUrl { get; set; }
	}
}
