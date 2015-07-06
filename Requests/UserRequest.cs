using Netface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netface.Requests
{
    public class UserRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public User ToUser(int id)
        {
            return new User(id, UserName, Password);
        }
    }
}