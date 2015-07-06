using Netface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netface.Requests
{
    public class ShowRequest
    {
        public string Name { get; set; }

        public Show ToShow(int id)
        {
            return new Show(id, Name);
        }

        public void Update(Show target)
        {
            target.Name = Name;
        }
    }
}