using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArsaOfisi.ViewComponents
{
    public class NavbarAdmin : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
