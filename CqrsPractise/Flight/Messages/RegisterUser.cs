namespace CqrsPractise.Flight
{
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

}