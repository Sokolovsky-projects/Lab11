using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab11.ViewModels
{
    class EnterViewModel : BindableBase
    {
        private string _login;
        public string Login 
        {
            get { return _login; } 
            set 
            {
                _login = value; 
                RaisePropertyChanged(nameof(Login));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        private DelegateCommand authorizeCommand;
        public ICommand AuthorizeCommand => authorizeCommand ??= new DelegateCommand(Authorize);

        private void Authorize()
        {
        }

    }
}
