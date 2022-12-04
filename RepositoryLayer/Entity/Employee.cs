using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryLayer.Entity
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
  
        public string EmployeeName { get; set; }
       
        public string ProfileImage { get; set; }
  
        public string Gender { get; set; }
      
        public string Department { get; set; }
       
        public DateTime StartDate { get; set; }
        
        public int Salary { get; set; }
    }
}
