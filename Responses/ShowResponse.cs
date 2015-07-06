using Netface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netface.Responses
{
    public class ShowResponse
    {
        public ShowResponse(Show show)
        {
            if (null == show)
                throw new ArgumentNullException();

            ShowId = show.Id;
            Name = show.Name;
        }

        public int ShowId { get; set; }
        public string Name { get; set; }
    }
}