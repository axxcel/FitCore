using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Post { get; set; }

        public User(int id, string login, string password, string post)
        {
            Id = id;
            Login = login;
            Password = password;
            Post = post;
        }

    }
}
