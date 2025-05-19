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

namespace chapter01
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

        private void CTN(object sender, RoutedEventArgs e)
        {
            style_custom_example win2 = new style_custom_example();
            win2.Owner=this;
            win2.Show();
        }
        private void style_window1(object sender, RoutedEventArgs e)
        {
            style_custom_example win2 = new style_custom_example();
            win2.Owner = this;
            win2.Show();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}