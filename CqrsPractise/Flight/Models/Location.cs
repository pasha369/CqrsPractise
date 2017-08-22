namespace CqrsPractise.Flight
{
    public class Location
    {
        public long Lat { get; }
        public long Lang { get; }

        public Location(long lat, long lang)
        {
            Lat = lat;
            Lang = lang;
        }
    }
}