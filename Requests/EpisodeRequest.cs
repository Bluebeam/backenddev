using Netface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netface.Requests
{
    public class EpisodeRequest
    {
        public string Name { get; set; }

        public Episode ToEpisode(int id)
        {
            return new Episode(id, Name);
        }

        public void Update(Episode target)
        {
            target.Name = Name;
        }
    }
}