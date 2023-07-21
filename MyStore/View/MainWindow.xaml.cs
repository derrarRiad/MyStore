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

namespace MyStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            Button btn = (Button)sender;
            btn.Foreground = Brushes.Black;
            btn.FontSize = 16;
            btn.FontWeight = FontWeights.Bold;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            Button btn = (Button)sender;
            btn.Background = Brushes.Transparent;
            btn.Foreground = Brushes.White;
            btn.FontSize = 16;
            btn.FontWeight = FontWeights.Light;
        }

        private void SubButton_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            Button btn = (Button)sender;
            btn.Background = Brushes.Transparent;
            btn.Foreground = Brushes.White;
            btn.FontSize = 12;
            btn.FontWeight = FontWeights.Light;
        }


        private void sales_btn_Click(object sender, RoutedEventArgs e)
        {
           
            if(sales_subMenu.Visibility == Visibility.Visible)
            {
                sales_subMenu.Visibility = Visibility.Collapsed;
                return;
            }
            sales_subMenu.Visibility = Visibility.Visible;
        }

        private void purchases_btn_Click(object sender, RoutedEventArgs e)
        {
            if (purchases_subMenu.Visibility == Visibility.Visible)
            {
                purchases_subMenu.Visibility = Visibility.Collapsed;
                return;
            }
            purchases_subMenu.Visibility = Visibility.Visible;
        }

        private void products_btn_Click(object sender, RoutedEventArgs e)
        {
            if (products_subMenu.Visibility == Visibility.Visible)
            {
                products_subMenu.Visibility = Visibility.Collapsed;
                return;
            }
            products_subMenu.Visibility = Visibility.Visible;
        }

        private void users_btn_Click(object sender, RoutedEventArgs e)
        {
            if (users_subMenu.Visibility == Visibility.Visible)
            {
                users_subMenu.Visibility = Visibility.Collapsed;
                return;
            }
            users_subMenu.Visibility = Visibility.Visible;
        }

        private void statistics_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
      
            this.Close();
        }
    }
}
