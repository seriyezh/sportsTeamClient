using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using IRSSReader;
using RSSReader.Entities;

namespace RSSReader
{
	public class NewsParser : INewsParser
	{
		private readonly IMapping _newsMapping;

		public NewsParser(IMapping newsMapping)
		{
			this._newsMapping = newsMapping;
		}

		public ICollection<News> Parse(Stream rssStream)
		{
			LinkedList<News> news = new LinkedList<News>();

			XDocument doc = XDocument.Load(rssStream);

			foreach (XElement newsEl in doc.Root.Descendants(this._newsMapping.NewsItem))
			{
				News newsItem = new News
				{
					Title = newsEl.Element(this._newsMapping.Title).Value,
					Description = newsEl.Element(this._newsMapping.Description).Value,
					Text = newsEl.Element(this._newsMapping.Text).Value,
					Date = Convert.ToDateTime(newsEl.Element(this._newsMapping.Date).Value),
				};

				var imgElement = newsEl.Element(this._newsMapping.ImageUrl);
				if (imgElement != null)
				{
					if (!string.IsNullOrWhiteSpace(imgElement.Value))
					{
						newsItem.ImgUrl = imgElement.Value;
					}
					else
					{
						newsItem.ImgUrl = imgElement.Attribute(this._newsMapping.ImageUrlAttr)?.Value;
					}
				}

				news.AddLast(newsItem);
			}

			return news;
		}
	}
}
