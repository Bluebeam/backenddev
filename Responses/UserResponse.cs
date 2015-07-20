using Bluebeam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bluebeam.Responses
{
    public class UserResponse
    {
        public UserResponse(User user)
        {
            if (null == user)
                throw new ArgumentNullException();

            UserId = user.Id;
            UserName = user.Name;
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}