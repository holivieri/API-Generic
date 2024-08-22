using GenericAPI.APIEntities;
using System;

namespace GenericAPI.APIRepositories
{
    public interface IUsersRepository
    {
        void Add(User user);
        User Get(Guid userId);
        User Get(string userName, string password);


    }
}
