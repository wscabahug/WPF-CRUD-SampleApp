using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Models
{
    public class User
    {
        public Guid Id { get; }
        public string Username { get; }
        public bool IsRegular { get; }
        public bool IsEnrolled { get; }

        public User(Guid id, string username, bool isRegular, bool isEnrolled)
        {
            Id = id;
            Username = username;
            IsRegular = isRegular;
            IsEnrolled = isEnrolled;
        }
    }
}
