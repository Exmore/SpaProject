using SpaProject.Domain.Models;
using System.Collections.Generic;

namespace SpaProject.DataAccess.Abstract
{
    public interface IUsersWithDepartmentsGetter
    {
        IEnumerable<UserWithDepartment> GetAllUsers();
        UserWithDepartment GetUser(int id);
        UserWithDepartment AddUser(UserWithDepartment user);
        bool Update(UserWithDepartment user);
        void Remove(int id);
    }
}
