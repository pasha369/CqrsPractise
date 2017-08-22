using System;
using System.Linq;

namespace CqrsPractise.Flight
{
    public class FlightRepository : IFlightRepository
    {
        public FlightItem Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<FlightItem> Get()
        {
            throw new NotImplementedException();
        }

        public void Create(FlightItem item)
        {
            
        }

        public void Update(FlightItem item)
        {
            
        }
    }
}