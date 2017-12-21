using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AggregationDataAccess;

namespace AggregationService.Controllers
{
    public class OwnersController : ApiController
    {
        UserEntities user_entities = new UserEntities();
        CarEntities car_entities = new CarEntities();
        OwnersEntities owner_entities = new OwnersEntities();

        public IEnumerable<Owners> Get()
        {
            List<Owners> owners = new List<Owners>();
            foreach (CarOwner car_owner in owner_entities.CarOwner)
            {
                User user = new User();
                foreach (User u in user_entities.User)
                    if (car_owner.IdUser == u.Id) user = u;

                Car car = new Car();
                foreach (Car c in car_entities.Car)
                    if (car_owner.IdCar == c.Id) car = c;
                owners.Add(new Owners(car_owner.Id, user, car));
            }

            return owners;
        }
    }
}
