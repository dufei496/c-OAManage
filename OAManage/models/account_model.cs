using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAManage.models
{
    internal class account_model:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _Account;
        public string Account {
            get { return _Account; }
            set {
                _Account = value;
                if (PropertyChanged != null) {
                    PropertyChanged(this, new PropertyChangedEventArgs("Account"));
                }
            }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }

    }
}
