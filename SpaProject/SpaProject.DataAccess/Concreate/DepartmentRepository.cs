using SpaProject.DataAccess.Abstract;
using SpaProject.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpaProject.DataAccess.Concreate
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments()
        {
            return new List<Department>
            {
                new Department{ Id = 1, Title ="IT Department"  },
                new Department{ Id = 2, Title="Marketing" }
            };
        }
    }
}
