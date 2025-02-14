using EmployeeManagement.Models;
using KudvenkatServerSideProject.Services;
using Microsoft.AspNetCore.Components;

namespace KudvenkatServerSideProject.Components.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject] IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected  override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }


       
    }
}
