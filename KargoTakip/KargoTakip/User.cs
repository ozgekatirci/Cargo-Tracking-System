using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip
{
    public class User
    {
        private string username;
        private string password;
        private string nameSurname;
        private int id;
        private string email;
    
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string NameSurname { get => nameSurname; set => nameSurname = value; }
        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }

    }
}
