using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AggregationDataAccess;

namespace AggregationService.Controllers
{
    public class UsersController : ApiController
    {
        UserEntities user_entities = new UserEntities();

        public IEnumerable<User> Get()
        {
            return user_entities.User;
        }
    }
}
