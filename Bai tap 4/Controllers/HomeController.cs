using Bai_tap_4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bai_tap_4.Controllers
{
    public class HomeController : Controller
    {

        QlbanVaLiContext db = new QlbanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listSanPham = db.TDanhMucSps.ToList(); 
            return View(listSanPham);
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
