using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDummy _dummy;
        private readonly IDummy2 _dummy2;

        

        public HomeController(ILogger<HomeController> logger, IDummy dummy, IDummy2 dummy2)
        {
            _logger = logger;
            _dummy = dummy;
            _dummy2 = dummy2;
        }

        public string Index()
        {
            string a = _dummy.Write();
            string b = _dummy2.WriteMore();
            return (a);
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