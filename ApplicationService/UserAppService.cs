using Domain;
using Repository;
using System;

namespace ApplicationService
{
    public class UserAppService
    {
        private readonly IUserRepository _userRepository;
        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public void CreateUser(UserViewModel model)
        {
            User user = new User();
            user.Name = model.Name;

            _userRepository.Add(user);
        }
    }
}
