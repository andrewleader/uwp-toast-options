using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpToastOptions
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ButtonPopToast_Click(object sender, RoutedEventArgs e)
        {
            var content = new ToastContentBuilder()
                .AddText("Hello from WPF!")
                .AddToastActivationInfo("openToast", ToastActivationType.Foreground)
                .AddButton("Perform background action", ToastActivationType.Background, "backgroundAction")
                .GetToastContent();

            ToastNotificationManager.CreateToastNotifier().Show(new ToastNotification(content.GetXml()));
        }

        private void ButtonClearToasts_Click(object sender, RoutedEventArgs e)
        {
            ToastNotificationManager.History.Clear();
        }
    }
}
