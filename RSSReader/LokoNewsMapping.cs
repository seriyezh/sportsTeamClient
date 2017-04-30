using System.Xml.Linq;
using IRSSReader;

namespace RSSReader
{
	public class LokoNewsMapping : IMapping
	{
		public string RssUri { get; } = "http://www.hclokomotiv.ru/news/news/rss/";

		private static readonly XNamespace xmlns = "http://backend.userland.com/rss2";
		private static readonly XNamespace xmlns2 = "http://news.yandex.ru";

		public XName NewsItem { get; } = xmlns.GetName("item");

		public XName Title { get; } = xmlns.GetName("title");
		public XName Description { get; } = xmlns.GetName("description");
		public XName Text { get; } = xmlns2.GetName("full-text");
		public XName Date { get; } = xmlns.GetName("pubDate");
		public XName ImageUrl { get; } = xmlns.GetName("enclosure");
		public string ImageUrlAttr { get; } = "url";
	}
}
