using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDataAccess
{
    public class Owners
    {
        public int Id { get; set; }
        public User user { get; set; }
        public Car car { get; set; }

        public Owners(int id, User user, Car car)
        {
            this.Id = id;
            this.user = user;
            this.car = car;
        }
    }
}
