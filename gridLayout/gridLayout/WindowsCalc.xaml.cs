using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gridLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WindowsCalc : ContentPage
    {
        double result, firstValue, secondValue;
        int flag;

        public WindowsCalc()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (resultText.Text == "0")
            {
                resultText.Text = "";
            }
            resultText.Text += btn.Text;
        }

        private void Clear_Button_Clicked(object sender, EventArgs e)
        {
            resultText.Text = "0";
            firstValue = 0;
            secondValue = 0;
        }

        private void Operation_Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                firstValue = Convert.ToDouble(resultText.Text);

                resultText.Text = "";


                Button btn = (Button)sender;

                switch (btn.Text)
                {
                    case "+":
                        flag = 1;
                        break;
                    case "-":
                        flag = 2;
                        break;
                    case "*":
                        flag = 3;
                        break;
                    case "/":
                        flag = 4;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception exception)
            {
                firstValue = 0;
            }
        }

        private void Result_Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                secondValue = Convert.ToDouble(resultText.Text);
                if (flag == 1)
                {
                    result = firstValue + secondValue;
                    resultText.Text = result.ToString();
                }
                else if (flag == 2)
                {
                    result = firstValue - secondValue;
                    resultText.Text = result.ToString();
                }
                else if (flag == 3)
                {
                    result = firstValue * secondValue;
                    resultText.Text = result.ToString();
                }
                else if (flag == 4)
                {
                    result = firstValue / secondValue;
                    resultText.Text = result.ToString();
                }
            }
            catch (Exception exception)
            {
                result = 0;
            }

        }
    }
}