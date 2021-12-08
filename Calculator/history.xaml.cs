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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace App1
{
    public sealed partial class history : Page
    {
        public history()
        {
            this.InitializeComponent();
            var HistoryList = buttons.Current.HistoryList1;
        }
        public void ClearHistory_Click(object sender, RoutedEventArgs e)
        {
            HistoryList.Items.Clear();
        }
    }
}
