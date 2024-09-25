using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Models
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password {  get; set; }

        public User() { }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public User(int id, string login, string password) : this(login, password)
        {
            Id = id;
        }
    }
}
