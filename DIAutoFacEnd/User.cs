using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI
{
    public class User
    {
        public string UserName { get; set; }

        public User(string userName)
        {
            UserName = userName;
        }
    }
}
