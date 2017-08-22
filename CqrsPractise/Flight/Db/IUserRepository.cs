namespace CqrsPractise.Flight
{
    public interface IUserRepository
    {
        void Activate(string token);
        void Register(string name);
    }
}