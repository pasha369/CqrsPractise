using System;
using System.Linq;

namespace CqrsPractise.Flight
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class FlightItem
    {
        public int Id { get; }
        public DateTime From { get; }
        public DateTime To { get; }
        public bool IsHasPlace { get; private set; }
        public bool IsActive { get; private set; }
        public Location Location { get; }

        public FlightItem(DateTime from, DateTime to, Location location)
        {
            From = from;
            To = to;
            Location = location;
        }

        public FlightItem(int id, DateTime from, DateTime to, Location location)
        {
            Id = id;
            From = from;
            To = to;
            Location = location;
        }
    }

    public class Location
    {
        public long Lat { get; }
        public long Lang { get; }

    }

    public interface IMessage
    {

    }

    public class Event : IMessage
    {

    }

    public class RegisterUser : Event
    {
        public string Name { get; }

        public RegisterUser(string name)
        {
            Name = name;
        }
    }

    public class ActivateUser : Event
    {
        public string Token { get; }

        public ActivateUser(string token)
        {
            Token = token;
        }
    }

    public class CreateFlightItem : Event
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

    public class UserEventHandler
    {
        public void Handle(RegisterUser message) { }
        public void Handle(ActivateUser message) { }
    }

    public class FlightEventHandler
    {
        public void Handle(CreateFlightItem message) {}
    }

    public class FlightRepository
    {
        public FlightItem Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<FlightItem> Get()
        {
            throw new NotImplementedException();
        }

        public void Save(FlightItem item)
        {
            
        }
    }
}
