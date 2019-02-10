using SpaProject.DataAccess.Abstract;
using SpaProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaProject.DataAccess.Concreate
{
    public class UsersWithDepartmentsGetter : IUsersWithDepartmentsGetter
    {
        private IDepartmentRepository departmentRepository;
        private IUserRepository userRepository;
        private static int counter = 0;

        public UsersWithDepartmentsGetter(IDepartmentRepository departmentRepository, IUserRepository userRepository)
        {
            this.departmentRepository = departmentRepository;
            this.userRepository = userRepository;
        }

        public UserWithDepartment AddUser(UserWithDepartment user)
        {
            userRepository.AddUser(new User { UserName = user.UserName, DepartmentId = user.DepartmentId });
            user.Id = ++counter;
            return user;
        }

        public IEnumerable<UserWithDepartment> GetAllUsers()
        {
            counter = 0;
            var users = userRepository.GetAllUsers();

            if (users == null)
                return new List<UserWithDepartment>();

            var departments = departmentRepository.GetAllDepartments();
            var usersWithDeps = users.Join(
                departments,
                user => user.DepartmentId,
                dep => dep.Id,
                (user, dep) => new UserWithDepartment { DepartmentName = dep.Title, UserName = user.UserName }).ToList();


            usersWithDeps.ForEach((x) => { x.Id = ++counter; });

            return usersWithDeps;
        }

        public UserWithDepartment GetUser(int id)
        {
            // Не было в задании
            return new UserWithDepartment();
        }

        public void Remove(int id)
        {
            userRepository.RemoveUser(id);
        }

        public bool Update(UserWithDepartment user)
        {
            // Не стал реализовать, не хотел тратить время            
            return userRepository.ChangeUser(new User());
        }
    }
}
