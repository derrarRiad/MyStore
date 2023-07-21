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
           Button btn = (Button)sender;
                btn.Background=Brushes.Tomato;
                btn.Foreground = Brushes.Black;
                btn.FontSize = 14;
                btn.FontWeight = FontWeights.Bold;

        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = Brushes.Transparent;
            btn.Foreground = Brushes.White;
            btn.FontSize = 12;
            btn.FontWeight = FontWeights.Normal;
        }
    }
}
