using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;

namespace Netface.Data
{
    public class Show
    {
        public Show(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.episodes = new List<Episode>();
        }

        private readonly int id;
        private readonly List<Episode> episodes;

        private string name;

        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public List<Episode> Episodes { get { return this.episodes; } }
    }
}