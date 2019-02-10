namespace SpaProject.Domain.Models
{
    public class UserWithDepartment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public string UserName { get; set; }
        public string DepartmentName { get; set; }                
    }
}
