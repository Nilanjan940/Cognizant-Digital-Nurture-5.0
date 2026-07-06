using System;
using System.Collections.Generic;

namespace _4_WebApi_Handson.Models
{
    public static class EmployeeData
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Dhruv",
                Salary = 70000,
                Permanent = true,
                DateOfBirth = new DateTime(1998, 7, 20),
                Department = new Department { Id = 11, Name = "Engineering" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "ASP.NET" },
                    new Skill { Id = 2, Name = "ReactJS" }
                }
            }
        };
    }
}
