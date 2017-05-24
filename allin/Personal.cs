using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allin
{
    class Personal
    {
        private string Name;
        private string Password;

        public Personal(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public bool Check(string name, string password)
        {
            if (name == Name && password == Password)
            {
                return true;
            }
            return false;
        }
    }
}
