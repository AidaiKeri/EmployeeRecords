using EmployeeRecordsSystem.Data;
using EmployeeRecordsSystem.Models;

namespace EmployeeRecordsSystem.Services
{
    public class EmployeeManagement
    {
        private readonly AppDbContext _dbContext;

        public EmployeeManagement(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public void RemoveEmployee(int employeeId)
        {
            var employee = _dbContext.Employees.Find(employeeId);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }
    }

}
