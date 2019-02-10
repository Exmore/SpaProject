using System.Collections.Generic;
using System.Web.Http;
using SpaProject.DataAccess.Abstract;
using SpaProject.Domain.Models;

namespace SpaProject.Controllers
{
    public class WebController : ApiController
    {        
        private IUsersWithDepartmentsGetter usersWithDepGetter;

        public WebController(IUsersWithDepartmentsGetter usersWithDepartmentsGetter)
        {
            usersWithDepGetter = usersWithDepartmentsGetter;
        }
        
        public IEnumerable<UserWithDepartment> GetAllUsers()
        {
            return usersWithDepGetter.GetAllUsers();
        }

        public UserWithDepartment GetUser(int id)
        {
            return usersWithDepGetter.GetUser(id);            
        }

        [HttpPost]
        public UserWithDepartment CreateUser(UserWithDepartment user)
        {
            return usersWithDepGetter.AddUser(user);
        }

        [HttpPut]
        public bool UpdateUser(UserWithDepartment user)
        {            
            return usersWithDepGetter.Update(user);
        }

        public void DeleteUser(int id)
        {
            usersWithDepGetter.Remove(id);
        }
    }
}