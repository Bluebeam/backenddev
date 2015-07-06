using Netface.Data;
using Netface.Requests;
using Netface.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Netface.Controllers
{
    public class ShowsController : ApiController
    {
        [HttpPost]
        [Route("shows")]
        public void NewShow(ShowRequest request)
        {
            ShowRepo.Instance.AddShow(request.ToShow(UniqueId.Next()));
        }

        [HttpGet]
        [Route("shows")]
        public List<ShowResponse> GetAll()
        {
            var query = from s in ShowRepo.Instance.GetAll()
                        select new ShowResponse(s);
            return query.ToList();
        }

        [HttpGet]
        [Route("shows/{showId}")]
        public ShowResponse GetShow(int showId)
        {
            var show = ShowRepo.Instance.FindById(showId);
            return new ShowResponse(show);
        }

        [HttpPut]
        [Route("shows/{showId}")]
        public void UpdateShow(int showId, [FromBody]ShowRequest request)
        {
            var show = ShowRepo.Instance.FindById(showId);
            request.Update(show);
        }

        [HttpPost]
        [Route("shows/{episodeId}/episodes")]
        public void NewEpisodeFor(int episodeId, [FromBody]EpisodeRequest request)
        {
            var show = ShowRepo.Instance.FindById(episodeId);

            if (show.Episodes.Select(p => p.Name).Any(p => p.Equals(request.Name, StringComparison.OrdinalIgnoreCase)))
                throw new HttpResponseException(HttpStatusCode.Forbidden);

            var episode = request.ToEpisode(UniqueId.Next());

            show.Episodes.Add(episode);
        }

        [HttpGet]
        [Route("shows/{showId}/episodes")]
        public List<EpisodeResponse> GetEpisodesFor(int showId)
        {
            var show = ShowRepo.Instance.FindById(showId);
            return show.Episodes.Select(p => new EpisodeResponse(p)).ToList();
        }

        [HttpPut]
        [Route("shows/{showId}/episodes/{episodeId}")]
        public void UpdateEpisodeFor(int showId, int episodeId, [FromBody]EpisodeRequest request)
        {
            var show = ShowRepo.Instance.FindById(showId);

            var query = from e in show.Episodes
                        where e.Id == episodeId
                        select e;

            var episode = query.First();
            request.Update(episode);
        }

        [HttpDelete]
        [Route("shows/{showId}/episodes/{episodeId}")]
        public void DeleteEpisodeFor(int showId, int episodeId)
        {
            var show = ShowRepo.Instance.FindById(showId);

            var query = from e in show.Episodes
                        where e.Id == episodeId
                        select e;

            var episode = query.First();

            show.Episodes.Remove(episode);
        }
    }
}