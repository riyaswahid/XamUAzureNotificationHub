using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamUNotif
{
	public partial class App : Application
	{
		public const string NotificationReceivedKey = "NotificationReceived";
		public const string MobileServiceUrl = "http://xamarinpushnotifhubbackend.azurewebsites.net";


		public App()
		{
			InitializeComponent();

			MainPage = new XamUNotif.MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
