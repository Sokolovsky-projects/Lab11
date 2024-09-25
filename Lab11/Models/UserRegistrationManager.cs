using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Models
{
    class UserRegistrationManager
    {
        private User _user;

        public void Registrate(string login, string password, string secondPassword)
        {
            if (password == secondPassword)
            {
                //todo регистрируем
            }
            else
            {
                //todo пароли не совпадают
            }
        }
    }
}
