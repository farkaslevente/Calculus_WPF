using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFHely
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;

        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TBResult.Text += btn.Content.ToString();
            second = Int32.Parse(TBResult.Text);
        }

        private void BTNClear_Click(object sender, RoutedEventArgs e)
        {
            TBResult.Clear();
        }

        private void BTNMinus_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TBResult.Text);
            op = '-';
            TBResult.Clear();
        }

        private void BTNPlus_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TBResult.Text);
            op = '+';
            TBResult.Clear();
        }

        private void BTNEquals_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(TBResult.Text);
            int result = 0;
            if (op == '+')
            {
                result = first + second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            if (TBResult.Text == "0")
            {
                TBResult.Clear();
            }
            TBResult.Text = result.ToString();
        }

        private void BTNDivide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TBResult.Text);
            op = '/';
            TBResult.Clear();
        }

        private void BTNTimes_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TBResult.Text);
            op = '*';
            TBResult.Clear();
        }
    }
}