using System.Collections.Generic;
using System.Linq;
using CqrsPractise.Flight.Models;

namespace CqrsPractise.Flight.Queries
{
    public interface IQuery<out TItem>
    {
        IEnumerable<TItem> Execute();
    }

    public class FlightsQuery : IQuery<FlightItem>
    {
        private readonly IQueryable<FlightItem> _flightItems;

        public FlightsQuery(IQueryable<FlightItem> flightItems)
        {
            _flightItems = flightItems;
        }

        public IEnumerable<FlightItem> Execute()
        {
            return _flightItems.Where(item => item.IsActive).ToList();
        }
    }
}
