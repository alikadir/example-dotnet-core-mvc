using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstDotnetCoreMVC.Entities.Employee
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // only for postgres 
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public List<EmployeeAddress> EmployeeAddress { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}