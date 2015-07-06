using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace Netface.Data
{
    public class ShowRepo
    {
        private static readonly Lazy<ShowRepo> LazyInstance = new Lazy<ShowRepo>(() => new ShowRepo());
        public static ShowRepo Instance
        {
            get
            {
                return LazyInstance.Value;
            }
        }

        public ShowRepo()
        {
            this.shows = new Dictionary<int, Show>();
        }

        private readonly IDictionary<int, Show> shows;

        public void AddShow(Show show)
        {
            if (null == show)
                throw new ArgumentNullException();

            shows.Add(show.Id, show);
        }

        public Show FindById(int id)
        {
            if (shows.ContainsKey(id))
                return shows[id];

            throw new KeyNotFoundException();
        }

        public IEnumerable<Show> GetAll()
        {
            return this.shows.Values.ToList();
        }
    }
}