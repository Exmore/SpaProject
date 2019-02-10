using SpaProject.Domain.Models;
using System.Collections.Generic;

namespace SpaProject.DataAccess.Abstract
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
