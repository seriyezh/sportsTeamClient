using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSSReader;
using Microsoft.Practices.Unity;
using RSSReader.Entities;

namespace WindowsPhoneApp.ViewModels
{
	public class NewsViewModel
	{
		private IRSSReader.IRSSReader _rssReader { get; set; }

		private ObservableCollection<News> _news = new ObservableCollection<News>();
		public ObservableCollection<News> News
		{
			get
			{
				if (this._news.Count == 0)
				{
					this.GetNews();
				}
				return this._news;
			}
		}

		public NewsViewModel(IRSSReader.IRSSReader rssReader)
		{
			this._rssReader = rssReader;
		}

		private async void GetNews()
		{
			var news = await this._rssReader.GetNews();
			foreach (var n in news)
			{
				this.News.Add(n);
			}
		}
	}
}
