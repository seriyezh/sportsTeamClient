using IRSSReader;
using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSSReader.Entities;
using System.Net.Http;
using System.Xml.Linq;

namespace RSSReader
{
    public class RSSReader : IRSSReader.IRSSReader
    {
        public string _rssUri = "http://www.hclokomotiv.ru/news/news/rss/";

        public async Task<ICollection<News>> GetNews()
        {
            HttpClient webClient = new HttpClient();

            var streamNews = await webClient.GetStreamAsync(_rssUri);

            var doc = XDocument.Load(streamNews);

            var news = doc.Root.Descendants("News");

            return new List<News> { };
        }
    }
}
