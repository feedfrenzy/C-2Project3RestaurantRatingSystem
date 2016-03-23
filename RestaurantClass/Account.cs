using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantClass
{
    public class Account
    {
        string username;
        string password;
        string type;

        public Account()
        {

        }

        public Account(string theName, string thePassword, string theType)
        {
            username = theName;
            password = thePassword;
            type = theType;
        }

        public string getUsername
        {
            get {return username;}
            set { username = value; }
        }

        public string getPassword
        {
            get { return password; }
            set { password = value; }
        }

        public string getType
        {
            get { return type; }
            set { type = value; }
        }


        public int validation(string theName, string thePassword, string theType)
        {

            if (String.IsNullOrEmpty(theName))
            {
                return -1;
            }
            else if (String.IsNullOrEmpty(thePassword))
            {
                return -2;
            }
            else if (String.IsNullOrEmpty(theType))
            {
                return -3;
            }
            else
            {
                return 0;
            }
        }

    }
}
