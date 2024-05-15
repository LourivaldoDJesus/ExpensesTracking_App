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
    /// Interaction logic for Buy.xaml
    /// </summary>
    public partial class Buy : Window
    {
        private static double Pprice;
        private static double Tdeposit;
        private static double InterestRate;
        private static double NofMonths;
        private static double FinalBBalance;
        private static double BandDivision;

        private HomeApp objBalanceB = new HomeApp();

        public static double Pprice1 { get => Pprice; set => Pprice = value; }
        public static double Tdeposit1 { get => Tdeposit; set => Tdeposit = value; }
        public static double InterestRate1 { get => InterestRate; set => InterestRate = value; }
        public static double NofMonths1 { get => NofMonths; set => NofMonths = value; }
        public static double FinalBBalance1 { get => FinalBBalance; set => FinalBBalance = value; }
        public static double BandDivision1 { get => BandDivision; set => BandDivision = value; }

        public Buy()
        {
            InitializeComponent();

           
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new HomeApp();
            window.Show();
            this.Hide();
           
        }

        private void NoBtn_Checked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void YesBtn_Checked(object sender, RoutedEventArgs e)
        {
            Window window = new Vehicle_B();
            window.Show();
            this.Hide();
        }

        private void FinalBalanceTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            
            //Setting the interest rate dividing by 100
            double Idivison = InterestRate1 / 100;

            BandDivision = HomeApp.Balance1 + Pprice1 * (1 +Tdeposit1 * Idivison);
            FinalBBalance1 = BandDivision1 / NofMonths1;
            FinalBalanceTxtBox.Text = String.Format("{0:C}", FinalBBalance1).ToString();

            // double calc = HomeApp.Balance1 + PurchasePrice1 * (1 + Tdeposit1 * InterestRate1);
            //FinalBalance1 = calc + Insurance1;
        }

        private void PpriceTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Pprice1 = double.Parse(PpriceTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                PpriceTxtBox.Focus();
            }

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

        private void NofMonthsTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                NofMonths1 = double.Parse(NofMonthsTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                NofMonthsTxtBox.Focus();
            }

        }
    }
}
