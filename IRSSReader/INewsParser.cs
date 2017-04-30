using System.Collections.Generic;
using System.IO;
using RSSReader.Entities;

namespace IRSSReader
{
	public interface INewsParser
	{
		ICollection<News> Parse(Stream rssStream);
	}
}
