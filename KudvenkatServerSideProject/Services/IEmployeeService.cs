using EmployeeManagement.Models;

namespace KudvenkatServerSideProject.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
