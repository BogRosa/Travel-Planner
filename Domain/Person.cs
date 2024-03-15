using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Person
    {
        public int PersonId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = HashPassword(value); }
        }

        private string HashPassword(string password)
        {
            
            return password; 
        }
    }
}
