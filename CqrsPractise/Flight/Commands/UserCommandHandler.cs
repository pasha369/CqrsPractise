namespace CqrsPractise.Flight
{
    public class UserCommandHandler
    {
        private readonly IUserRepository _userRepository;

        public UserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Handle(RegisterUser message)
        {
            _userRepository.Register(message.Name);
        }

        public void Handle(ActivateUser message)
        {
            _userRepository.Activate(message.Token);
        }
    }
}