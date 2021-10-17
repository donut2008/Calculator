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

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class buttons : Page
    {
        public bool status;
        public bool dot;
        public double PreviousValue = 0.0;
        public char Operation;
        public bool FirstTime = true;
        public double var1, var2;
        public buttons()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
            result.Text = "0";
        }

        private void OperationMethod()
        {
            switch (Operation)
            {
                case '+':
                    {
                        PreviousValue += double.Parse(result.Text);
                        break;
                    }
                case '-':
                    {
                        PreviousValue -= double.Parse(result.Text);
                        break;
                    }
                case '*':
                    {
                        PreviousValue *= double.Parse(result.Text);
                        break;
                    }
                case '/':
                    {
                        PreviousValue /= double.Parse(result.Text);
                        break;
                    }
                case '2':
                    {
                        double square = Math.Pow(double.Parse(result.Text), 2);
                        PreviousValue = square;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case '3':
                    {
                        double cube = Math.Pow(double.Parse(result.Text), 3);
                        PreviousValue = cube;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'q':
                    {
                        double sqrt = Math.Sqrt(double.Parse(result.Text));
                        PreviousValue = sqrt;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'c':
                    {
                        double cbrt = Math.Pow(double.Parse(result.Text), 1.0 / 3.0);
                        PreviousValue = cbrt;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn0.Content;
            else
                result.Text = btn0.Content.ToString();
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            result.Text = (-1.0 * double.Parse(result.Text)).ToString();
        }

        private void btnDec_Click(object sender, RoutedEventArgs e)
        {
            if (dot == false)
            {
                result.Text += btnDec.Content.ToString();
                dot = true;
                status = true;
            }
        }

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
            if (Operation != '\0')
            {
                OperationMethod();
                result.Text = PreviousValue.ToString();
                PreviousValue = 0.0;
            }
            status = false;
            FirstTime = true;
            Operation = '\0';
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn1.Content;
            else
            {
                result.Text = btn1.Content.ToString();
                status = true;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn2.Content;
            else
            {
                result.Text = btn2.Content.ToString();
                status = true;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn3.Content;
            else
            {
                result.Text = btn3.Content.ToString();
                status = true;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!FirstTime)
            {
                OperationMethod();
                Operation = '+';
                status = false;
            }
            else
            {
                PreviousValue = double.Parse(result.Text);
                Operation = '+';
                status = false;
                FirstTime = false;
            }
            result.Text = "0";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn4.Content;
            else
            {
                result.Text = btn4.Content.ToString();
                status = true;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn5.Content;
            else
            {
                result.Text = btn5.Content.ToString();
                status = true;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn6.Content;
            else
            {
                result.Text = btn6.Content.ToString();
                status = true;
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (!FirstTime)
            {
                OperationMethod();
                Operation = '-';
                status = false;
            }
            else
            {
                PreviousValue = double.Parse(result.Text);
                Operation = '-';
                status = false;
                FirstTime = false;
            }
            result.Text = "0";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn7.Content;
            else
            {
                result.Text = btn7.Content.ToString();
                status = true;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn8.Content;
            else
            {
                result.Text = btn8.Content.ToString();
                status = true;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn9.Content;
            else
            {
                result.Text = btn9.Content.ToString();
                status = true;
            }
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            if (!FirstTime)
            {
                OperationMethod();
                Operation = '*';
                status = false;
            }
            else
            {
                PreviousValue = double.Parse(result.Text);
                Operation = '*';
                status = false;
                FirstTime = false;
            }
            result.Text = "0";
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'q';
            OperationMethod();
        }

        private void btnCbrt_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'c';
            OperationMethod();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = 0.ToString();
            var1 = 0.0;
            var2 = 0.0;
            PreviousValue = 0.0;
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (!FirstTime)
            {
                OperationMethod();
                Operation = '/';
                status = false;
            }
            else
            {
                PreviousValue = double.Parse(result.Text);
                Operation = '/';
                status = false;
                FirstTime = false;
            }
            result.Text = "0";
        }

        private void btnSq_Click(object sender, RoutedEventArgs e)
        {
            Operation = '2';
            OperationMethod();
        }

        private void btnCb_Click(object sender, RoutedEventArgs e)
        {
            Operation = '3';
            OperationMethod();
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "0")
            {
                string str = result.Text;
                int n = str.Length;
                result.Text = (str.Substring(0, n - 1));
            }
            if (result.Text.Length == 0)
            {
                result.Text = "0";
                status = false;
            }
        }
    }

}

