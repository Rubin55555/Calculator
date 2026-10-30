using System;
using System.Windows;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFields() == false) return;

            double a = Convert.ToDouble(num1.Text);
            double b = Convert.ToDouble(num2.Text);
            double sum = a + b;
            txtResult.Text = "תוצאה: " + sum;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFields() == false) return;

            double a = Convert.ToDouble(num1.Text);
            double b = Convert.ToDouble(num2.Text);
            double sum = a - b;
            txtResult.Text = "תוצאה: " + sum;
        }

        private void Kaful_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFields() == false) return;

            double a = Convert.ToDouble(num1.Text);
            double b = Convert.ToDouble(num2.Text);
            double sum = a * b;
            txtResult.Text = "תוצאה: " + sum;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFields() == false) return;

            double a = Convert.ToDouble(num1.Text);
            double b = Convert.ToDouble(num2.Text);

            if (b == 0)
            {
                txtResult.Text = "אי אפשר לחלק באפס";
                return;
            }

            double sum = a / b;
            txtResult.Text = "תוצאה: " + sum;
        }

        private void AC_Click(object sender, RoutedEventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            txtResult.Text = "תוצאה: ";
        }

        private bool CheckFields()
        {
            if (num1.Text == "" || num2.Text == "")
            {
                txtResult.Text = "נא למלא את שתי התיבות!";
                return false;
            }
            return true;
        }
    }
}