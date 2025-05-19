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
using OAManage.models;

namespace OAManage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private account_model account_model;
        public MainWindow()
        {
            InitializeComponent();
            account_model = new account_model();
            this.DataContext = account_model;
        }


        private void logon_click(object sender, RoutedEventArgs e)
        {
            if (account_model.Account == "admin" && account_model.Password == "123456")
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("登陆失败");
                account_model.Account = "";
                account_model.Password = "";
            }
        }
    }
}