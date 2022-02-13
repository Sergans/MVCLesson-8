using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCLesson_8.ViewModels
{
    public class ViewEmployee
    {
        [HiddenInput(DisplayValue=false)]
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
