using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(XamUNotif.Backend.Startup))]

namespace XamUNotif.Backend
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureMobileApp(app);
		}
	}
}