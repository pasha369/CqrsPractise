using System.Collections.Generic;
using System.Linq;
using CqrsPractise.Flight.Models;

namespace CqrsPractise.Flight.Queries
{
    public class UserQuery : IQuery<User>
    {
        private readonly IQueryable<User> _users;
        private readonly long _id;

        public UserQuery(IQueryable<User> users, long id)
        {
            _users = users;
            _id = id;
        }

        public IEnumerable<User> Execute()
        {
            return _users.Where(user => user.Id == _id).ToList();
        }
    }
}
