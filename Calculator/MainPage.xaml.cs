using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// NavigationView
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void navigator_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            var selectedItem = (Microsoft.UI.Xaml.Controls.NavigationViewItem)args.SelectedItem;
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(settings), null);
            }
            else
            {
                string selectedItemTag = selectedItem.Tag.ToString();
                switch (selectedItemTag)
                {
                    case "calc":
                        ContentFrame.Navigate(typeof(buttons), null);
                        break;
                    case "temp":
                        ContentFrame.Navigate(typeof(temperature), null);
                        break;
                    case "hist":
                        ContentFrame.Navigate(typeof(history), null);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
