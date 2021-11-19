using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// settings page
    /// </summary>
    public sealed partial class settings : Page
    {
        public ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        public ObservableCollection<GridThemeItem> gridItems = new ObservableCollection<GridThemeItem>();
        private GridThemeItem CreateNewTheme(byte borderR, byte borderG, byte borderB, byte bgR, byte bgG, byte bgB)
        { return new GridThemeItem(new SolidColorBrush(Color.FromArgb(255, borderR, borderG, borderB)), new SolidColorBrush(Color.FromArgb(255, bgR, bgG, bgB))); }
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
        public void YellowChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void RedChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void GreenChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void BlueChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void DcLChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void DcDChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void WALChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void WADChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
        public void AmoledChecked(object sender, RoutedEventArgs e)
            => customThemeSelected();
    }
}