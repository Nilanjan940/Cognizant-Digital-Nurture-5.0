using _2_WebApi_Handson.Models;
using System.Collections.Generic;
using System.Linq;

namespace _2_WebApi_Handson.Services
{
    public class EmployeeService
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Dhruv Kushwaha", Department = "Software", Salary = 80000 },
            new Employee { Id = 2, Name = "Anjali Verma", Department = "Testing", Salary = 65000 },
            new Employee { Id = 3, Name = "Rohan Mehta", Department = "Support", Salary = 55000 }
        };

        public List<Employee> GetAllEmployees() => employees;

        public Employee GetById(int id) => employees.FirstOrDefault(e => e.Id == id);

        public void Add(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public bool Update(int id, Employee updated)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return false;

            emp.Name = updated.Name;
            emp.Department = updated.Department;
            emp.Salary = updated.Salary;
            return true;
        }

        public bool Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return false;

            employees.Remove(emp);
            return true;
        }
    }
}
