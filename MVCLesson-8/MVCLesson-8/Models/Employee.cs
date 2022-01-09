using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MVCLesson_8.Models
{
    public class Employee
    {
        [HiddenInput(DisplayValue =false)]
        public int Id { get; set; }
       [Required]
       
        public string Name { get; set; }
        [Required]
        public string Famaly { get; set; }
        [Required]
        
        public int Age { get; set; }
        [Required]
        public string Post { get; set; }

    }
}
