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
using System.Windows.Shapes;

namespace Expenses_Application
{
    /// <summary>
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        private static double SavingsAmount;
        private static double Time;
        private static double InterestRate;
        private static double TargetAmount;

        private Vehicle objBalanceB = new Vehicle();

        public static double SavingsAmount1 { get => SavingsAmount; set => SavingsAmount = value; }
        public static double Time1 { get => Time; set => Time = value; }
        public static double InterestRate1 { get => InterestRate; set => InterestRate = value; }
        public static double TargetAmount1 { get => TargetAmount; set => TargetAmount = value; }

        //private static double Tdeposit;


        public Savings()
        {
            InitializeComponent();
        }

        private void SavingsAmountTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                SavingsAmount1 = double.Parse(SavingsAmountTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                SavingsAmountTxtBox.Focus();
            }

        }

        private void TimeTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Time1 = double.Parse(TimeTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                TimeTxtBox.Focus();
            }

        }

        private void InterestRateTxtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                InterestRate1 = double.Parse(InterestRateTxtBox1.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                InterestRateTxtBox1.Focus();
            }

        }

        private void TargetAmountTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            
            //Setting the interest rate dividing by 100
            double Intdivison = InterestRate1 / 100;
            double balance1 = SavingsAmount1 * (1 + Intdivison);
            TargetAmount1 = balance1 / Time1;
            TargetAmountTxtBox.Text = String.Format("{0:C}", TargetAmount1).ToString();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Hide();
        }
    }
}
