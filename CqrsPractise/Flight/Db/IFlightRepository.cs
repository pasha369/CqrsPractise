using System.Linq;

namespace CqrsPractise.Flight
{
    public interface IFlightRepository
    {
        void Create(FlightItem item);
        IQueryable<FlightItem> Get();
        FlightItem Get(long id);
        void Update(FlightItem item);
    }
}