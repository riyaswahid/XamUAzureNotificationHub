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
<<<<<<< HEAD
			_msgReceiver = DependencyService.Get<IMessageReceiver>();
=======
			_msgReceiver = DependencyService.Get<IMessageReceiver>(DependencyFetchTarget.GlobalInstance);
>>>>>>> refs/heads/test-android
			_msgReceiver.MessageReceived += OnMessageReceived;
			btnSend.Clicked += OnBtnSendClicked;
		}

		void OnBtnSendClicked(object sender, EventArgs e)
		{
			Debug.WriteLine($"Sending message: " + txtMsg.Text);
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			_msgReceiver.MessageReceived -= OnMessageReceived;
		}

		void OnMessageReceived(object sender, string msg)
		{
			lblMsg.Text = msg;
		}
	}
}
