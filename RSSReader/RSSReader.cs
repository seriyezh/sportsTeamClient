using IRSSReader;
using System.Collections.Generic;
using System.Threading.Tasks;
using RSSReader.Entities;
using System.Net.Http;
using System.IO;

namespace RSSReader
{
	public class RSSReader : IRSSReader.IRSSReader
	{
		private INewsParser _newsParser;
		private IMapping _newsMapping;

		public RSSReader(INewsParser newsParser, IMapping newsMapping)
		{
			this._newsParser = newsParser;
			this._newsMapping = newsMapping;
		}

		public async Task<ICollection<News>> GetNews()
		{
			HttpClient webClient = new HttpClient();
			Stream streamNews = await webClient.GetStreamAsync(this._newsMapping.RssUri);

			ICollection<News> news = this._newsParser.Parse(streamNews);

			return news;
		}
	}
}
