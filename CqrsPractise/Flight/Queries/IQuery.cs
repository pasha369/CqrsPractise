using System.Collections.Generic;

namespace CqrsPractise.Flight.Queries
{
    public interface IQuery<out TItem>
    {
        IEnumerable<TItem> Execute();
    }
}