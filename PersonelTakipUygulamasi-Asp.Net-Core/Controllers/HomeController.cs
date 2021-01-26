using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonelTakipUygulamasi_Asp.Net_Core.Data;
using PersonelTakipUygulamasi_Asp.Net_Core.Data.Repositories;
using PersonelTakipUygulamasi_Asp.Net_Core.Models;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly PersonelTakipDbContext _personelTakipDbContext;
        EmployeeRepository employeeRepository = new EmployeeRepository(_personelTakipDbContext);
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
