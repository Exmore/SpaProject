using SpaProject.DataAccess.Abstract;
using SpaProject.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpaProject.DataAccess.Concreate
{
    public class UserRepository : IUserRepository
    {
        private static int counter = 3;
        private static List<User> users = new List<User>
        {
                new User{ Id = 1, DepartmentId = 1, UserName = "johnny81" },
                new User{ Id = 2, DepartmentId = 2, UserName = "missmary" },
                new User{ Id = 3, DepartmentId = 1, UserName = "jijames" }
        };

        public void AddUser(User user)
        {
            user.Id = ++counter;
            users.Add(user);            
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public void RemoveUser(int id)
        {
            try
            {
                users.Remove(users.Find(x => x.Id == id));
            }
            catch
            {

            }            
        }

        public bool ChangeUser(User user)
        {
            return true;
        }
    }
}
