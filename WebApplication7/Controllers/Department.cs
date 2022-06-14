using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class Department : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult DeptDetails()
        {
            Dept dobj = new Dept { deptno = 100, dname = "Sales", location = "Mumbai" };
            return View(dobj);
        }
    }
}
