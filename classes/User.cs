using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Organiser.classes
{
    static class User
    {
        private static int id;
        private static string username;
        private static string password;
        private static string email;

        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

        public static void fillUser(int id, string username, string password, string email)
        {
            User.Id = id;
            User.Username = username;
            User.Password = password;
            User.Email = email;
        }
    }
}
