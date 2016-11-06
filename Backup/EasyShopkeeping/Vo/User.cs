using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping
{
    public class User
    {
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private String userCategory;

        public String UserCategory
        {
            get { return userCategory; }
            set { userCategory = value; }
        }
       
       
    }
}
