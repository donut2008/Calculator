using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CalculatorWUI3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class temperature : Page
    {
        public double c, f;
        public temperature()
        {
            this.InitializeComponent();
            List<String> conversion = new List<String>();
            conversion.Add("Celsius to Fahrenheit");
            conversion.Add("Fahrenheit to Celsius");
            convselect.ItemsSource = conversion;
        }
        private void TextBox_OnBeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }
        private void TextBox_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            input.Text = new String(input.Text.Where(char.IsDigit).ToArray());
        }
        private async void EmptyInputDialog()
        {
            ContentDialog contentDialog = new ContentDialog()
            {
                Title = "Invalid value",
                Content = "Please enter a valid value.",
                CloseButtonText = "OK"
            };
            await contentDialog.ShowAsync();
        }
        public void ConverterChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedValue.ToString() == "Celsius to Fahrenheit")
            {
                if (input.Text != "")
                {
                    c = double.Parse(input.Text);
                    f = (c * 1.8) + 32;
                    output.Text = f.ToString();
                }
                else
                    EmptyInputDialog();
            }
            else if (comboBox.SelectedValue.ToString() == "Fahrenheit to Celsius")
            {
                if (input.Text != "")
                {
                    f = double.Parse(input.Text);
                    c = (f - 32) / 1.8;
                    output.Text = c.ToString();
                }
                else
                    EmptyInputDialog();
            }
        }
    }
}
