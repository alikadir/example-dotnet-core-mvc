using System.Collections.Generic;
using System.Linq;
using FirstDotnetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace FirstDotnetCoreMVC.ViewComponents
{
    public class SampleViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke(int count)
        {
            List<string> list = new List<string>()
            {
                "ali", "veli", "osman", "nuri", "mehmet"
            };
           

            return View(list);
        }
    }
}