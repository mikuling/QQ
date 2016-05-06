using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ
{
    [Serializable] 
    class User
    {
        private string username;
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}
