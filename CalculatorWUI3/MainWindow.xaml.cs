using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CalculatorWUI3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Title = "Calculator";
        }
        private void navigator_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var selectedItem = (NavigationViewItem)args.SelectedItem;
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
                    default:
                        break;
                }
            }
        }
    }
}
