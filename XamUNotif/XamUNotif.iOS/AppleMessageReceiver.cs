using System;
using Xamarin.Forms;
using XamUNotif.iOS;

[assembly: Dependency(typeof(AppleMessageReceiver))]
namespace XamUNotif.iOS
{
	public class AppleMessageReceiver : IMessageReceiver
	{
		public event EventHandler<string> MessageReceived;

		internal void Handle(string msg)
		{
			MessageReceived?.Invoke(this, msg);
		}
	}
}