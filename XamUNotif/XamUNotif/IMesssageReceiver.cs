using System;

namespace XamUNotif
{
	public interface IMessageReceiver
	{
		event EventHandler<string> MessageReceived;
	}
}
