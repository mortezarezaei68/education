using Domain;
using System;

namespace Repository
{
    public class UserRepository:IUserRepository
    {
        public void Add(User user)
        {
            Console.WriteLine(user.Name);
        }
    }
}
