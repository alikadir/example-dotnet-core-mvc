using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstDotnetCoreMVC.Models
{
    public class Employee
    {
        [Key] 
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public List<EmployeeAddress> EmployeeAddress { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}