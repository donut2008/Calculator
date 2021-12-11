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
        public int factorial(int x)
        {
            int i = 1;
            for (int s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }
        public void OperationMethod()
        {
            switch (Operation)
            {

                case '/':
                    {
                        PreviousValue /= double.Parse(result.Text);
                        break;
                    }

                case '*':
                    {
                        PreviousValue *= double.Parse(result.Text);
                        break;
                    }
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
                case 'b':
                    {
                        double cbrt = Math.Pow(double.Parse(result.Text), 1.0 / 3.0);
                        PreviousValue = cbrt;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'l':
                    {
                        double log10 = Math.Log10(double.Parse(result.Text));
                        PreviousValue = log10;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'n':
                    {
                        double LN = Math.Log(double.Parse(result.Text));
                        PreviousValue = LN;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'S':
                    {
                        double Sin = Math.Sin(double.Parse(result.Text));
                        PreviousValue = Sin;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'C':
                    {
                        double Cos = Math.Cos(double.Parse(result.Text));
                        PreviousValue = Cos;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'T':
                    {
                        double Tan = Math.Tan(double.Parse(result.Text));
                        PreviousValue = Tan;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 's':
                    {
                        double SinInv = Math.Asin(double.Parse(result.Text));
                        PreviousValue = SinInv;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'c':
                    {
                        double CosInv = Math.Acos(double.Parse(result.Text));
                        PreviousValue = CosInv;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 't':
                    {
                        double TanInv = Math.Acos(double.Parse(result.Text));
                        PreviousValue = TanInv;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'r':
                    {
                        int var1, var2;
                        var1 = factorial(Convert.ToInt32(PreviousValue));
                        var2 = factorial(Convert.ToInt32(PreviousValue) - Convert.ToInt32(result.Text));
                        PreviousValue = double.Parse(Convert.ToString(var1 / var2));
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'R':
                    {
                        int var1, var2, var3;
                        var1 = factorial(Convert.ToInt32(PreviousValue));
                        var2 = factorial(Convert.ToInt32(PreviousValue) - Convert.ToInt32(result.Text));
                        var3 = factorial(Convert.ToInt32(result.Text));
                        PreviousValue = double.Parse(Convert.ToString(var1 / (var3 * var2)));
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'o':
                    {
                        double inverse = 1.0 / double.Parse(result.Text);
                        PreviousValue = inverse;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                case 'f':
                    {
                        double Fact = 1;
                        for (int i = 1; i <= Convert.ToInt32(result.Text); i++)
                        {
                            Fact = Fact * i;
                        }
                        PreviousValue = Fact;
                        result.Text = PreviousValue.ToString();
                        status = false;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn0.Content;
            else
                result.Text = btn0.Content.ToString();
        }

        public void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            result.Text = (-1.0 * double.Parse(result.Text)).ToString();
        }

        public void btnDec_Click(object sender, RoutedEventArgs e)
        {
            if (dot == false)
            {
                result.Text += btnDec.Content.ToString();
                dot = true;
                status = true;
            }
        }

        public void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn1.Content;
            else
            {
                result.Text = btn1.Content.ToString();
                status = true;
            }
        }

        public void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn2.Content;
            else
            {
                result.Text = btn2.Content.ToString();
                status = true;
            }
        }

        public void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn3.Content;
            else
            {
                result.Text = btn3.Content.ToString();
                status = true;
            }
        }

        public void btnAdd_Click(object sender, RoutedEventArgs e)
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

        public void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn4.Content;
            else
            {
                result.Text = btn4.Content.ToString();
                status = true;
            }
        }

        public void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn5.Content;
            else
            {
                result.Text = btn5.Content.ToString();
                status = true;
            }
        }

        public void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn6.Content;
            else
            {
                result.Text = btn6.Content.ToString();
                status = true;
            }
        }

        public void btnSub_Click(object sender, RoutedEventArgs e)
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

        public void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn7.Content;
            else
            {
                result.Text = btn7.Content.ToString();
                status = true;
            }
        }

        public void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn8.Content;
            else
            {
                result.Text = btn8.Content.ToString();
                status = true;
            }
        }

        public void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (status == true)
                result.Text += btn9.Content;
            else
            {
                result.Text = btn9.Content.ToString();
                status = true;
            }
        }

        public void btnMul_Click(object sender, RoutedEventArgs e)
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

        public void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'q';
            OperationMethod();
        }

        public void btnCbrt_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'b';
            OperationMethod();
        }

        public void btnClear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = 0.ToString();
            var1 = 0.0;
            var2 = 0.0;
            PreviousValue = 0.0;
        }

        public void btnDiv_Click(object sender, RoutedEventArgs e)
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

        public void btnSq_Click(object sender, RoutedEventArgs e)
        {
            Operation = '2';
            OperationMethod();
        }

        public void btnCb_Click(object sender, RoutedEventArgs e)
        {
            Operation = '3';
            OperationMethod();
        }

        public void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
        }

        public void btnBackspace_Click(object sender, RoutedEventArgs e)
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

        public void btnLog_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'l';
            OperationMethod();
        }

        public void btnLN_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'n';
            OperationMethod();
        }

        public void btnSin_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'S';
            OperationMethod();
        }

        public void btnCos_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'C';
            OperationMethod();
        }

        public void btnTan_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'T';
            OperationMethod();
        }

        public void btnSinInv_Click(object sender, RoutedEventArgs e)
        {
            Operation = 's';
            OperationMethod();
        }

        public void btnCosInv_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'c';
            OperationMethod();
        }

        public void btnTanInv_Click(object sender, RoutedEventArgs e)
        {
            Operation = 't';
            OperationMethod();
        }

        public void btnFact_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'f';
            OperationMethod();
        }

        public void btnNPR_Click(object sender, RoutedEventArgs e)
        {
            if (!FirstTime)
            {
                OperationMethod();
                Operation = 'r';
                status = false;
            }
            else
            {
                PreviousValue = double.Parse(result.Text);
                Operation = 'r';
                status = false;
                FirstTime = false;
            }
            result.Text = "0";
        }

        private void btnNCR_Click(object sender, RoutedEventArgs e)
        {
            if (!FirstTime)
            {
                OperationMethod();
                Operation = 'R';
                status = false;
            }
            else
            {
                PreviousValue = double.Parse(result.Text);
                Operation = 'R';
                status = false;
                FirstTime = false;
            }
            result.Text = "0";
        }

        private void btn1X_Click(object sender, RoutedEventArgs e)
        {
            Operation = 'o';
            OperationMethod();
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
    }
}
