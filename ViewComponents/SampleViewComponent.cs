using System.Collections.Generic;
using System.Linq;
using FirstDotnetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace FirstDotnetCoreMVC.ViewComponents
{
    public class SampleViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            List<Employee> employeeList;
            using (var db = new EmployeeDbContext())
            {
                employeeList = db.Employees.ToList();
            }

            return View(employeeList);
        }
    }
}