using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double secondnum;
        double firstnum;
        string end = null;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button_click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(label2.Text) || label2.Text == "0")
            {
                label2.Text = (sender as Button).Content.ToString();
                label3.Content += (sender as Button).Content.ToString();
            }
            else
            {
                label2.Text += (sender as Button).Content.ToString();
                label3.Content += (sender as Button).Content.ToString();
            }


        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            double now = 0;
            int a = 0;
            if (end != null)
            {

                now = double.Parse(label2.Text);
                a++;
            }


            if (string.IsNullOrEmpty(end))
            {
                label3.Content += (sender as Button).Content.ToString();
                end = (sender as Button).Content.ToString();
                firstnum = double.Parse(label2.Text);

                label2.Text += (sender as Button).Content.ToString();
            }
            else
            {
                string lazim = label3.Content.ToString();

                lazim = lazim.Remove(lazim.IndexOf(end));


                label3.Content = null;
                label3.Content = lazim.ToString();
                label3.Content += (sender as Button).Content.ToString();
                end = (sender as Button).Content.ToString();


                label2.Text += (sender as Button).Content.ToString();
            }

            label2.Text = "0";



        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {

            label3.Content = null;
            label2.Text = null;

        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            label3.Content = null;
            label2.Text = null;
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(label2.Text))
            {
                string number = (label2.Text);
                label2.Text = (number.Remove(number.Length - 1)).ToString();
                label3.Content = (number.Remove(number.Length - 1)).ToString();
            }
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(label2.Text))
            {
                double number = int.Parse(label2.Text);
                label2.Text = (Math.Sqrt(number)).ToString();
            }
        }

        private void button_24_Click(object sender, RoutedEventArgs e)
        {
            if (end != null)
            {
                secondnum = double.Parse(label2.Text);
                if (end == "+")
                {

                    label2.Text = "0";
                    label2.Text = (firstnum + secondnum).ToString();

                }
                else if (end == "-")
                {

                    label2.Text = "0";
                    label2.Text = (firstnum - secondnum).ToString();

                }
                else if (end == "*")
                {

                    label2.Text = "0";
                    label2.Text = (firstnum * secondnum).ToString();

                }
                else if (end == "/")
                {

                    if (secondnum == 0)
                    {
                        label3.Content = "xeta";
                        label2.Text = "Xeta";

                    }
                    else
                    {

                        label2.Text = "0";
                        label2.Text = (firstnum / secondnum).ToString();
                    }


                }

            }

            end = null;
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(label2.Text))
            {
                double number = int.Parse(label2.Text);
                if (number == 0)
                {
                    label2.Text = "ERROR";
                }
                else
                {
                    label2.Text = (number * number).ToString();
                }

            }
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(label2.Text))
            {
                double number = double.Parse(label2.Text);
                label2.Text = (number / 100).ToString();
            }
        }

        private void button_23_Click(object sender, RoutedEventArgs e)
        {
            string number = (label2.Text);
            if (!string.IsNullOrEmpty(label2.Text))
            {
                if (number[number.Length - 1] != ',') label2.Text += ",";
            }
        }

        private void button_21_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(label2.Text))
            {
                double number = double.Parse(label2.Text);
                label2.Text = (number * (-1)).ToString();
            }
        }
    }
}
