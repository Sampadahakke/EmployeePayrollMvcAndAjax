using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseLayer
{
    public class EmployeeModel
    {

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string ProfileImage { get; set; }

        [Required]  
        public string Gender { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int Salary { get; set; }
    }
}
