using EmployeeManagement.Models;

namespace EmployeeManagementAPI.Models
{
    public interface IDepartmentRepasitory
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
