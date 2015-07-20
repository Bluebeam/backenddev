using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bluebeam.Data
{
    public class UniqueId
    {
        private static readonly Lazy<UniqueId> LazyInstance = new Lazy<UniqueId>(() => new UniqueId());
        public static UniqueId Instance
        {
            get
            {
                return LazyInstance.Value;
            }
        }

        private readonly object nextIdLock = new object();
        private int nextId;

        public int NextId()
        {
            lock (nextIdLock)
            {
                return ++nextId;
            }
        }

        public static int Next()
        {
            return Instance.NextId();
        }
    }
}