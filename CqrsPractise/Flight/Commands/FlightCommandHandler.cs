using CqrsPractise.Flight.Db;
using CqrsPractise.Flight.Messages;
using CqrsPractise.Flight.Models;

namespace CqrsPractise.Flight.Commands
{
    public class FlightCommandHandler
    {
        private readonly IFlightRepository _flightRepository;

        public FlightCommandHandler(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public void Handle(CreateFlightItem message)
        {
            var flight = new FlightItem(message.From, message.To, message.Location);
            _flightRepository.Create(flight);
        }

        public void Handle(BookFlight message)
        {
            var flight = message.FlightItem;
            flight.Passengers.Add(message.User);
            _flightRepository.Update(flight);
        }
    }
}