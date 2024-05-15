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
    /// Interaction logic for HomeApp.xaml
    /// </summary>
    public partial class HomeApp : Window
    {
        private static double MonthlyIncome;
        private static double TaxDeduction;
        private static double Groceries;
        private static double WaterLights;
        private static double Travel;
        private static double CellphoneTelephone;
        private static double Other;
        private static double Balance;

        public static double MonthlyIncome1 { get => MonthlyIncome; set => MonthlyIncome = value; }
        public static double TaxDeduction1 { get => TaxDeduction; set => TaxDeduction = value; }
        public static double Groceries1 { get => Groceries; set => Groceries = value; }
        public static double WaterLights1 { get => WaterLights; set => WaterLights = value; }
        public static double Travel1 { get => Travel; set => Travel = value; }
        public static double CellphoneTelephone1 { get => CellphoneTelephone; set => CellphoneTelephone = value; }
        public static double Other1 { get => Other; set => Other = value; }
        public static double Balance1 { get => Balance; set => Balance = value; }

        List<double> VExpenses= new List<double>();

        public HomeApp()
        {
            InitializeComponent();

           

        }

        private void MonthlyIncometxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MonthlyIncome1 = double.Parse(MonthlyIncometxtBox.Text);

            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                MonthlyIncometxtBox.Focus();
            }

        }

        private void MonthlyTaxDeductiontxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
               TaxDeduction1 = double.Parse(MonthlyTaxDeductiontxtBox.Text);

            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                MonthlyTaxDeductiontxtBox.Focus();
            }

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
           
            string FirstBalance;
            FirstBalance = BalancetxtBox.Text;

            Balance1 = MonthlyIncome1 - TaxDeduction1 - Groceries1 - WaterLights1 - Travel1 - CellphoneTelephone1 - Other1;
            
            BalancetxtBox.Text = String.Format("{0:C}", Balance1).ToString();

        }

        private void GroceriesExpensestxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Groceries1 = double.Parse(GroceriesExpensestxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                GroceriesExpensestxtBox.Focus();
            }

        }

        private void Water_LightsExpensestxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
               WaterLights1 = double.Parse(Water_LightsExpensestxtBox.Text);

            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                Water_LightsExpensestxtBox.Focus();
            }

        }

        private void TravelExpensestxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
               Travel1 = double.Parse(TravelExpensestxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                TravelExpensestxtBox.Focus();
            }

        }

        private void Cellphone_TelephoneExpensestxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CellphoneTelephone1 = double.Parse(Cellphone_TelephoneExpensestxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                Cellphone_TelephoneExpensestxtBox.Focus();
            }

        }

        private void OtherExpensestxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Other1 = double.Parse(OtherExpensestxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numerical value!");
                OtherExpensestxtBox.Focus();
            }

        }

        private void BalancetxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RentBtn_Checked(object sender, RoutedEventArgs e)
        {
            Window window = new Rent();
            window.Show();
            this.Hide();
        }

        private void BuyBtn_Checked(object sender, RoutedEventArgs e)
        {
            Window window = new Buy();
            window.Show();
            this.Hide();
        }

        

    }
}
