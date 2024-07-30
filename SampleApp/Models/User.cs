using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Models
{
    class User
    {
        public string Username { get; }
        public bool IsRegular { get; }
        public bool IsEnrolled { get; }

        public User(string username, bool isRegular, bool isEnrolled)
        {
            Username = username;
            IsRegular = isRegular;
            IsEnrolled = isEnrolled;
        }
    }
}
