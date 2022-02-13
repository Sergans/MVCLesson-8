using MVCLesson_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCLesson_8.Data;

namespace MVCLesson_8.Services
{
    public class Manager : IServices
    {
        private readonly DataBase _database;
        
        public Manager(DataBase dataBase)
        {
            _database = dataBase;
        }
        public void Add(Employee employee)
        {
            _database.Add(employee);
            _database.SaveChanges();
        }
        
        public void Delete(int id)
        {
            var employee=GetById(id);
            _database.Remove(employee);
            _database.SaveChanges();
        }
       
        public List<Employee> GetAll()
        {
            return _database.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            var employees = GetAll();
            foreach(Employee employee in employees)
            {
                if(employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }

        public void Update(Employee model)
        {
            foreach(var employee in GetAll())
            {
                if(employee.Id == model.Id)
                {
                    employee.Name =model.Name;
                    employee.Age = model.Age;
                    employee.Post =model.Post;
                    employee.Famaly = model.Famaly;
                    _database.SaveChanges();
                }
              
            }
           
        }
    }
}
