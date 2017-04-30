using System.Xml.Linq;

namespace IRSSReader
{
	public interface IMapping
	{
		string RssUri { get; }

		XName NewsItem { get; }
		XName Title { get; }
		XName Description { get; }
		XName Text { get; }
		XName Date { get; }
		XName ImageUrl { get; }
		string ImageUrlAttr { get; }
	}
}
