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
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        private static double MonthlyRentalAmount;
        private static double RentFinalBalance;
        private HomeApp objBalanceRt = new HomeApp();
        
        
            

        public static double MonthlyRentalAmount1 { get => MonthlyRentalAmount; set => MonthlyRentalAmount = value; }
        public static double RentFinalBalance1 { get => RentFinalBalance; set => RentFinalBalance = value; }

        public Rent()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new HomeApp();
            window.Show();
            this.Hide();
        }

        private void RentalAmountTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MonthlyRentalAmount1 = double.Parse(RentalAmountTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                RentalAmountTxtBox.Focus();
            }

        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            
            RentFinalBalance = HomeApp.Balance1 - MonthlyRentalAmount1;
            FinalBalanceTxtBox.Text = String.Format("{0:C}", RentFinalBalance1).ToString();
        }


        private void YesBtn_Checked(object sender, RoutedEventArgs e)
        {
            Window window = new Vehicle();
            window.Show();
            this.Hide();
        }

        private void NoBtn_Checked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FinalBalanceTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
