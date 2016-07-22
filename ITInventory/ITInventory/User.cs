using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITInventory
{
    public class User
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private bool isAdmin;
        private int id;

        public User(string username, string firstName,
            string lastName, string password, bool isAdmin,
            int id)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.isAdmin = isAdmin;
            this.id = id;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName;}
            set { lastName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
    }
}
