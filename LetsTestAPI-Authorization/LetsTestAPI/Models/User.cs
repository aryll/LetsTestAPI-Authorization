using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsTestAPI.Models
{
    public class User
    {
        public User(string userId, string password)
        {
            UserId = userId;
            Password = password;
            Role = "Administrators";
        }

        public bool IsInRole(string role)
        {
            return String.Equals(role, Role);
        }


        public string UserId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}