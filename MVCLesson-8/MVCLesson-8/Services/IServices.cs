﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCLesson_8.Models;

namespace MVCLesson_8.Services
{
   public interface IServices
    {
        void Add(Employee employee);
        List<Employee>Get();
    }
}