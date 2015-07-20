using Bluebeam.Data;
using Bluebeam.Requests;
using Bluebeam.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Bluebeam.Controllers
{
    public class UsersController : ApiController
    {
        [HttpPost]
        [Route("users")]
        public void Post(UserRequest request)
        {
            UserRepo.Instance.AddUser(request.ToUser(UniqueId.Next()));
        }

        [HttpGet]
        [Route("users")]
        public List<UserResponse> Get()
        {
            var query = from u in UserRepo.Instance.GetAll()
                        select new UserResponse(u);

            return query.ToList();
        }

        [HttpGet]
        [Route("users/{userId}")]
        public UserResponse Get(int userId)
        {
            var user = UserRepo.Instance.FindById(userId);
            return new UserResponse(user);
        }
    }
}