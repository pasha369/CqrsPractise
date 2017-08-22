using System;

namespace CqrsPractise.Flight
{
    public class CreateFlightItem : Message
    {
        public DateTime From { get; }
        public DateTime To { get; }
        public Location Location { get; }

        public CreateFlightItem(DateTime from, DateTime to, Location location)
        {
            From = from;
            To = to;
            Location = location;
        }
    }

    public class BookFlight : Message
    {
        public User User { get; }
        public FlightItem FlightItem { get; }

        public BookFlight(User user, FlightItem flightItem)
        {
            User = user;
            FlightItem = flightItem;
        }

    }
}