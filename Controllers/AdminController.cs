using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCookieAuthSample.Models;
using Microsoft.AspNetCore.Authorization;

namespace MVCCookieAuthSample.Controllers
{
    public class AdminController:Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


    }
}