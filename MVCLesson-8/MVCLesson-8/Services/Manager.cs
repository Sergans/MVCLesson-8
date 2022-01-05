using MVCLesson_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLesson_8.Services
{
    public class Manager : IServices
    {
        private readonly ListEmployee _employees;
        //public List<Employee> ListEmpl { get; set; }
        public Manager(ListEmployee employees)
        {
            _employees = employees;
        }
        public void Add(Employee employee)
        {
            _employees.ListEmpl.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employees.ListEmpl.Remove(employee);
        }
        public Employee GetFamaly(Employee employee)
        {
            return employee;
        }

        public List<Employee> GetAll()
        {
            return _employees.ListEmpl;
        }
    }
}
