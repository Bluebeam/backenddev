using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;

namespace Netface.Data
{
    public class User
    {
        public User(int id, string name, string password)
            : this(id, name, password.ToSecureString())
        {
        }

        public User(int id, string name, SecureString password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.FavoriteShowIds = new List<int>();
        }

        private readonly int id;
        private readonly string name;
        private readonly SecureString password;

        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } }
        internal SecureString Password { get { return this.password; } }

        public List<int> FavoriteShowIds { get; private set; }
    }
}