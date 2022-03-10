using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_projem.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
