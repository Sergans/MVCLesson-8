using MVCLesson_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLesson_8.Services
{
    public class Manager : IServices
    {
        public List<Employee> ListEmpl { get; set; }
        public Manager()
        {
            ListEmpl = new List<Employee>();
        }
        public void Add(Employee employee)
        {
            ListEmpl.Add(employee);
        }

        public List<Employee> Get()
        {
            return ListEmpl;
        }
    }
}
