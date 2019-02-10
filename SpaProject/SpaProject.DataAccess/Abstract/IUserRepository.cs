using SpaProject.Domain.Models;
using System.Collections.Generic;

namespace SpaProject.DataAccess.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();        
        void AddUser(User user);
        void RemoveUser(int id);
        bool ChangeUser(User user);
    }
}
