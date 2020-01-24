using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name can not exceed 50 charcters ")]

        public string Name { set; get; }

        [Required]
        [Display(Name="Office Email")]
        public string Email { set; get; }

        [Required]
        public Dept ? Department { get; set; }







    }
}
