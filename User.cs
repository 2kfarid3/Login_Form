using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form
{
    internal class User
    {
        private string _username;
        private string _password;
        private string _role;

        public string Username
        {
            get { return _username; }
            private set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }

        public string Role
        {
            get { return _role; }
            private set { _role = value; }
        }

        public User(string username, string password, string role = "User")
        {
            _username = username;
            _password = password;
            _role = role;
        }
    }
}
