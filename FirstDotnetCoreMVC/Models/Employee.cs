using System;
using System.ComponentModel.DataAnnotations;

namespace FirstDotnetCoreMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}