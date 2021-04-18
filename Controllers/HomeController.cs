using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Data;
using MVC_CRUD.Models;

namespace MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVC_CRUDContext _context;

        public HomeController(MVC_CRUDContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var issues = _context.Issue.FromSqlRaw("EXEC GetAllIssues").ToList();
            var severities = _context.Severity.FromSqlRaw("EXEC GetAllSeverities").ToList();

            ViewBag.SeverityID = new SelectList(severities, "Id", "SeverityName");

            return View(issues);
        }
    }
}
