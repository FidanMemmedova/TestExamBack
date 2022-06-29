using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeternaBack.Data;
using PeternaBack.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PeternaBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Services);
        }
    }
}
