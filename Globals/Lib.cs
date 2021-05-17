using System;
using Windows.Data.Xml.Dom; 
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications;


namespace Debug.Globals
{
    public class Lib
    {
        public static void CreateWin10Notification(string msg)
        {
            /*string message = "Changed Discrod-status to " + msg;
            string xml = $"<?xml version=\"1.0\"?><toast><visual><binding template=\"ToastText01\"><text id=\"1\">{message}</text></binding></visual></toast>";
            XmlDocument toastXml = new XmlDocument();
            toastXml.LoadXml(xml);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier("Discord advertiser for alt:V").Show(toast);
            
*/            
            new ToastContentBuilder()
                .AddText("Andrew sent you a picture")
                .AddAppLogoOverride(new Uri("https://picsum.photos/48?image=883"), ToastGenericAppLogoCrop.Circle)
                .AddText("Check this out, The Enchantments in Washington!")
                .Show();
        }
    }
}