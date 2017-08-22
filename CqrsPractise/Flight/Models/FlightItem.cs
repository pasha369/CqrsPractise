using System;
using System.Collections.Generic;

namespace CqrsPractise.Flight
{
    public class FlightItem
    {
        public int Id { get; }
        public DateTime From { get; }
        public DateTime To { get; }
        public bool IsHasPlace { get; private set; }
        public bool IsActive { get; private set; }
        public Location Location { get; }
        public List<User> Passengers { get;}

        public FlightItem(DateTime from, DateTime to, Location location)
        {
            From = from;
            To = to;
            Location = location;
            Passengers = new List<User>();
        }

        public FlightItem(int id, DateTime from, DateTime to, Location location)
            : this(from, to, location)
        {
            Id = id;
        }

        public void AddPassenger(User user)
        {
            Passengers.Add(user);
        }
    }
}