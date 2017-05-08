using IRSSReader;
using Microsoft.Practices.Unity;
using RSSReader;

namespace WindowsPhoneApp.ViewModels
{
	public class ViewModelLocator
	{
		public static IUnityContainer Container { get; private set; }

		public NewsViewModel News
		{
			get
			{
				return Container.Resolve<NewsViewModel>();
			}
		}

		static ViewModelLocator()
		{
			Container = new UnityContainer();
		}

		public ViewModelLocator()
		{
			Container.RegisterType<IMapping, LokoNewsMapping>();
			Container.RegisterType<INewsParser, NewsParser>();
			Container.RegisterType<IRSSReader.IRSSReader, RSSReader.RSSReader>();

			Container.RegisterType<NewsViewModel>();
		}
	}
}
