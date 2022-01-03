using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CalculatorCanary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class settings : Page
    {
        public settings()
        {
            this.InitializeComponent();
        }
        public async void customThemeSelected()
        {
            ContentDialog contentDialog = new ContentDialog()
            {
                Title = "under development",
                CloseButtonText = "OK"
            };
            await contentDialog.ShowAsync();
        }
        public void LightChecked(object sender, RoutedEventArgs e)
            => (Window.Current.Content as FrameworkElement).RequestedTheme = ElementTheme.Light;
        public void DarkChecked(object sender, RoutedEventArgs e)
            => (Window.Current.Content as FrameworkElement).RequestedTheme = ElementTheme.Dark;
        public void DefaultChecked(object sender, RoutedEventArgs e)
            => (Window.Current.Content as FrameworkElement).RequestedTheme = ElementTheme.Default;
    }
}
