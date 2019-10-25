using System;
using System.Collections.Generic;

namespace FirstDotnetCoreMVC.Entities.Employee
{
    public class EmployeeDetail
    {
        public int EmployeeDetailId { get; set; }
        public DateTime BirthDay { get; set; }
        public bool HasFamily { get; set; } = false;
        public int? ChildCount { get; set; }
        public string DirectorName { get; set; } = "GM";

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}