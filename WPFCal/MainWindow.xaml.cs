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

namespace WPFCal
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string liczbaPierwsza;
        string liczbaDruga;
        char rodzajDzialania = ' ';

        private void BT_1_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(1);
        }

        private void BT_2_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(2);
        }

        private void BT_3_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(3);
        }

        private void BT_4_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(4);
        }

        private void BT_5_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(5);
        }

        private void BT_6_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(6);
        }

        private void BT_7_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(7);
        }

        private void BT_8_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(8);
        }

        private void BT_9_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(9);
        }

        private void BT_0_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(0);
        }

        private void BT_DoubleZero_Click(object sender, RoutedEventArgs e)
        {
            Dzialanie(00);
        }

        private void BT_Dot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BT_Plus_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '+';
            txtDisplay.Text = "";
        }

        private void BT_Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (rodzajDzialania)
            {
                case ('+'):
                    txtDisplay.Text = (int.Parse(liczbaPierwsza) + int.Parse(liczbaDruga)).ToString();
                    break;
                case ('-'):
                    txtDisplay.Text = (int.Parse(liczbaPierwsza) - int.Parse(liczbaDruga)).ToString();
                    break;
                case ('*'):
                    txtDisplay.Text = (int.Parse(liczbaPierwsza) * int.Parse(liczbaDruga)).ToString();
                    break;
                case ('/'):
                    txtDisplay.Text = (int.Parse(liczbaPierwsza) / int.Parse(liczbaDruga)).ToString();
                    break;
            }
            liczbaPierwsza = "";
            liczbaDruga = "";
            rodzajDzialania = ' ';
        }

        private void BT_Minus_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '-';
            txtDisplay.Text = "";
        }

        private void BT_Increase_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '*';
            txtDisplay.Text = "";
        }

        private void BT_Split_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '/';
            txtDisplay.Text = "";
        }

        private void BT_Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dzialanie(int liczba)
        {
            if (rodzajDzialania == ' ')
            {
                liczbaPierwsza += liczba;
                txtDisplay.Text = liczbaPierwsza;
            }
            else
            {
                liczbaDruga += liczba;
                txtDisplay.Text = liczbaDruga;
            }
        }
    }
}
