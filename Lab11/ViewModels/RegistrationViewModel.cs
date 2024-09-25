using Lab11.Models;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab11.ViewModels
{
    class RegistrationViewModel : BindableBase
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

        private string _secondPassword;
        public string SecondPassword
        {
            get { return _secondPassword; }
            set
            {
                _secondPassword = value;
                RaisePropertyChanged(nameof(SecondPassword));
            }
        }

        private DelegateCommand registrateCommand;
        public ICommand RegistrateCommand => registrateCommand ??= new DelegateCommand(Registrate);

        private void Registrate()
        {
            //todo регистрация
            UserRegistrationManager manager = new UserRegistrationManager();

            manager.Registrate(Login, Password, SecondPassword);
        }

    }
}
