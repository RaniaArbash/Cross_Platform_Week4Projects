using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week4Projects
{
    public partial class CalculatorPage : ContentPage
    {
        int num1, num2;
        string op;
        List<String> names = new List<string> { "1","2","3","4" };
        public CalculatorPage()
        {
            InitializeComponent();
            mylist.ItemsSource = names;
        }
        public void Clear_Clicked(object sender, EventArgs e)
        {
            number.Text = "";

        }
        public void Number_Clicked(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            number.Text = number.Text + ((Button)sender).Text;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (((Button)sender).Text == "+")
            {
                num1 = Convert.ToInt32(number.Text);

                op = "+";
                number.Text = "";
            }
            else if (((Button)sender).Text == "-")
            {
                num1 = Convert.ToInt32(number.Text);
                op = "-";
                number.Text = "";
            }
            else if (((Button)sender).Text == "*")
            {
                num1 = Convert.ToInt32(number.Text);
                op = "*";
                number.Text = "";
            }
            else if (((Button)sender).Text == "/")
            {
                num1 = Convert.ToInt32(number.Text);
                op = "/";
                number.Text = "";
            }
            else if (((Button)sender).Text == "=")
            {
                num2 = Convert.ToInt32(number.Text);
                if (op == "+")
                {
                    number.Text = (num1 + num2).ToString();
                }
            }
        }

    }
}
