using Streamish.Models;
using System.Collections.Generic;

namespace Streamish.Repositories
{
    public interface IUserProfileRepository
    {
        void AddUserProfile(UserProfile user);
        void Delete(int id);
        List<UserProfile> GetAllUserProfiles();
        UserProfile GetUserProfileById(int id);
        void Update(UserProfile user);
    }
}