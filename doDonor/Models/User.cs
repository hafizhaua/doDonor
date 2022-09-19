using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class User
    {
        protected int _userID;
        protected string? _username;
        protected string? _password;

        public User(int id, string? username, string? password)
        {
            UserID = id;
            Username = username;
            Password = password;
        }

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string? Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string? Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool login(string username, string password)
        {
            return true;
        }

        public bool logout()
        {
            return true;
        }
    }
}
