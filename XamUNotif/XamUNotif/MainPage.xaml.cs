using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamUNotif
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		IMessageReceiver _msgReceiver;

		protected override void OnAppearing()
		{
			base.OnAppearing();

			MessagingCenter.Subscribe<object, string>(this, App.NotificationReceivedKey, OnMessageReceived);
			btnSend.Clicked += OnBtnSendClicked;
		}

		void OnMessageReceived(object sender, string msg)
		{
			Device.BeginInvokeOnMainThread(() => {
				lblMsg.Text = msg;
			});
		}

		void OnBtnSendClicked(object sender, EventArgs e)
		{
			Debug.WriteLine($"Sending message: " + txtMsg.Text);
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			MessagingCenter.Unsubscribe<object>(this, App.NotificationReceivedKey);
		}

	}
}
