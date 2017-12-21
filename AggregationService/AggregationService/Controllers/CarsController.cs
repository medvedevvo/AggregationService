using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AggregationDataAccess;

namespace AggregationService.Controllers
{
    public class CarsController : ApiController
    {
        CarEntities car_entities = new CarEntities();

        public IEnumerable<Car> Get()
        {
            return car_entities.Car;
        }
    }
}
