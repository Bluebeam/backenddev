using Netface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netface.Responses
{
    public class EpisodeResponse
    {
        public EpisodeResponse(Episode source)
        {
            if (null == source)
                throw new ArgumentNullException();

            EpisodeId = source.Id;
            Name = source.Name;
        }

        public int EpisodeId { get; set; }
        public string Name { get; set; }
    }
}