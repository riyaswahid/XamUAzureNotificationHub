using System;
using Xamarin.Forms;
using XamUNotif.Droid;

[assembly: Dependency(typeof(AndroidMessageReceiver))]
namespace XamUNotif.Droid
{
	public class AndroidMessageReceiver : IMessageReceiver
	{
		public event EventHandler<string> MessageReceived;

		internal void Handle(string msg)
		{
			MessageReceived?.Invoke(this, msg);
		}
	}
}