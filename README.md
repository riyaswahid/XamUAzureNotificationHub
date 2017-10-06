# Sending and receiving push notifications with Xamarin.Forms and Azure Notification Hub
This repo contains the code for the Lightning Lecture "Push notifications with Azure Notification Hub" available at https://university.xamarin.com/lightninglectures

## Topics covered

* Setup Azure Notification Hub for use with Android, iOS and Windows (UWP)
* Configure FCM for notifications on Android
* Configure APNS for notifications on iOS
* Configure WNS for notifications on Windows
* Build a Xamarin.Forms app to handle notifications
* Implement the platform specific native steps required to receive push notifications
* Implement and deploy a custom Azure Mobile App Service (.NET) to send notifications via the Azure Notification Hub
* Connect the Xamarin.Forms app to the .NET backend

***Please note that the solution requires an active Azure subscription that is available for free at https://portal.azure.com - the Notification Hub and backend used in the lecture are not meant for direct use and will be switched off without further warning.***

## Useful links
This section contains links for further reading. I found them helpful while investigating push notifications across the shown platforms.

### Azure
* Azure Portal: https://portal.azure.com
* Adrian Hall's book "Develop Cloud Connected Mobile Apps with Xamarin and Microsoft Azure": https://adrianhall.github.io/develop-mobile-apps-with-csharp-and-azure/chapter5/concepts/
* Notification Hub Rest API: https://msdn.microsoft.com/en-us/library/azure/dn530746.aspx
* Azure Notification Hub docs: https://docs.microsoft.com/en-us/azure/notification-hubs/
* Azure Mobile Apps .NET SDK: https://github.com/Azure/azure-mobile-apps-net-client
* Push Notification Tags ("$InstallationId" feature): https://blogs.msdn.microsoft.com/writingdata_services/2016/01/22/adding-push-notification-tags-from-an-azure-mobile-apps-client/
* Tags for targeted push messages: https://docs.microsoft.com/en-us/azure/notification-hubs/notification-hubs-tags-segment-push-message#tag-expressions
* Use managed Client for Mobile Apps for push notifications: https://docs.microsoft.com/en-us/azure/app-service-mobile/app-service-mobile-dotnet-how-to-use-client-library#pushnotifications
* What `GetPush().RegisterAsync()` really does: check out Adrian's book chapter 5 (https://adrianhall.github.io/develop-mobile-apps-with-csharp-and-azure/chapter5/concepts/) and find in there _"The /push/installations endpoint is part of App Service Push - a feature of the Azure App Service resource. This exists on your .azurewebsites.net domain. It is not part of Notification Hubs."_.
You can find the source of this `NotificationInstallationsController` at https://github.com/Azure/azure-mobile-apps-net-server/blob/04d75cadc137cc478f98edfa1fa5b868e5548dfd/src/Microsoft.Azure.Mobile.Server.Notifications/Controllers/NotificationInstallationsController.cs. It is called from https://github.com/Azure/azure-mobile-apps-net-client/blob/8f0fc245f29c5b3245ce27e8428b0f4a90b948bc/src/Microsoft.Azure.Mobile.Client/Push/PushHttpClient.cs#L27.
* Azure Notification Hub FAQ: https://docs.microsoft.com/en-us/azure/notification-hubs/notification-hubs-push-notification-faq

### Android
* Firebase App Console: http://console.firebase.google.com/
* Push notifications in Android with Xamarin: https://developer.xamarin.com/guides/android/application_fundamentals/notifications/firebase-cloud-messaging/
* Android FCM payloads JSON: https://firebase.google.com/docs/cloud-messaging/concept-options
* Extracting message data when app is in the background: https://firebase.google.com/docs/cloud-messaging/android/receive
* Microsoft docs about using FCM with Azure: https://docs.microsoft.com/en-us/azure/notification-hubs/notification-hubs-android-push-notification-google-fcm-get-started

### iOS
* Apple developer portal: https://developer.apple.com
* Push notifications in iOS with Xamarin: https://developer.xamarin.com/guides/ios/platform_features/user-notifications/deprecated/remote_notifications_in_ios/
* Apple APNS payloads JSON: https://developer.apple.com/library/content/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/CreatingtheNotificationPayload.html
* Ray Wenderlich's push notifications tutorial with `UNUserNotificationCenter`: https://www.raywenderlich.com/156966/push-notifications-tutorial-getting-started
* NWPusher to test push notifications directly from your Mac via APNS: https://github.com/noodlewerk/NWPusher

### Windows
* Windows developer portal: https://developer.microsoft.com respectively https://developer.microsoft.com/en-us/dashboard/
* Windows WNS docs: https://docs.microsoft.com/en-us/windows/uwp/controls-and-patterns/tiles-and-notifications-windows-push-notification-services--wns--overview
* Toast templates for WNS: https://msdn.microsoft.com/en-us/library/windows/apps/hh761494.aspx
* Test send WNS notifications: http://pushtestserver.azurewebsites.net/wns/

MIT License

Copyright (c) 2017 René Ruppert

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.






