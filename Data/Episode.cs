using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netface.Data
{
    public class Episode
    {
        public Episode(int id, string name)
        {
            if (null == name)
                throw new ArgumentNullException();

            this.id = id;
            this.name = name;
        }

        private readonly int id;
        private string name;

        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } set { this.name = value; } }
    }
}