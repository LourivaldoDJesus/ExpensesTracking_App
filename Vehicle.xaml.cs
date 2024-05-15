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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
        private static double ModelMake;
        private static double PurchasePrice;
        private static double Tdeposit;
        private static double InterestRate;
        private static double Insurance;
        private static double FinalBalance;

        private Rent objBalanceB = new Rent();

        public static double ModelMake1 { get => ModelMake; set => ModelMake = value; }
        public static double PurchasePrice1 { get => PurchasePrice; set => PurchasePrice = value; }
        public static double Tdeposit1 { get => Tdeposit; set => Tdeposit = value; }
        public static double InterestRate1 { get => InterestRate; set => InterestRate = value; }
        public static double Insurance1 { get => Insurance; set => Insurance = value; }
        public static double FinalBalance1 { get => FinalBalance; set => FinalBalance = value; }

        public Vehicle()
        {
            InitializeComponent();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Rent();
            window.Show();
            this.Hide();
        }

        private void InsuranceTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Insurance1 = double.Parse(InsuranceTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                InsuranceTxtBox.Focus();
            }

        }

        private void InterestRateTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                InterestRate1 = double.Parse(InterestRateTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                InterestRateTxtBox.Focus();
            }

        }

        private void PurchasePriceTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                PurchasePrice1 = double.Parse(PurchasePriceTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                PurchasePriceTxtBox.Focus();
            }

        }

        private void ModelMakeTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ModelMake1 = double.Parse(ModelMakeTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                ModelMakeTxtBox.Focus();
            }

        }

        private void FinalBalanceTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            //Setting the interest rate dividing by 100
            double Idivison = InterestRate1 / 100;

            double calc = Rent.RentFinalBalance1 + PurchasePrice1 * (1 + Tdeposit1 * Idivison);
            FinalBalance1 = calc + Insurance1;
            FinalBalanceTxtBox.Text = String.Format("{0:C}", FinalBalance1).ToString();
            
            double exceed = HomeApp.MonthlyIncome1 * 0.75;

            if (exceed > FinalBalance1)
            {
                MessageBox.Show("\nYour total expenses exceed your income by 75% !");
            };

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Hide();
        }

        private void TdepositTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Tdeposit1 = double.Parse(TdepositTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                TdepositTxtBox.Focus();
            }

        }

        private void NoBtn_Checked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void YesBtn_Checked(object sender, RoutedEventArgs e)
        {
            Window window = new Savings();
            window.Show();
            this.Hide();
        }
    }
}
